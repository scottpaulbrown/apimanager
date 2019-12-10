using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Serialization;

namespace APIManager.Logic {
    public class GenericCodeGenerator {
        protected TagMapper mapper;

        public GenericCodeGenerator() {
            mapper = new TagMapper();
            mapper.AddMapping(Tags.Tab, (opt, variable) => "\t");
            mapper.AddMapping(Tags.NewLine, (opt, variable) => "\n");
            mapper.AddMapping(Tags.Entity.EntityName, (opt, variable) => opt.Entity.EntityName);
            mapper.AddMapping(Tags.Entity.EntityNameLower, (opt, variable) => $"{opt.Entity.EntityName.Substring(0, 1).ToLower()}{opt.Entity.EntityName.Substring(1)}");
            mapper.AddMapping(Tags.Project.DotNetNamespace, (opt, variable) => opt.Project.DotNetNamespace);
            mapper.AddCustomMapping(Tags.Entity.EntityFieldList, (opt, variable) => GetEntityFields(opt, variable));
        }

        public void GenerateTemplateGroup(GenerateCodeOptions opt, TemplateGroup group) {
            foreach (var template in group.Templates) {
                if (template.GenerateTemplate) {
                    GenerateTemplate(opt, template.Template);
                }
            }
        }

        public void GenerateTemplate(GenerateCodeOptions opt, TemplateFile template) {
            // first create the template
            string path = Path.Combine(opt.TemplatePath, template.ProjectType, template.LanguageType, $"{template.FileName}.txt");
            string code = GenerateCode(opt, path);
            // create the path folder name
            string genPathFolder = GenerateCodeFromTemplate(opt, template.GenerationPathMask);
            // now save the file to the appropriate location            
            var genPath = Path.Combine(GetProjectPath(opt.Project, template.ProjectType, template.LanguageType), genPathFolder);
            if (!Directory.Exists(genPath)) {
                Directory.CreateDirectory(genPath);
            }

            // create the file name
            string fileName = GenerateCodeFromTemplate(opt, template.GeneratedFileMask);
            var filePath = Path.Combine(genPath, fileName);
            File.WriteAllText(filePath, code);
        }

        public List<FileVariable> GetVariables(string template) {
            // get a list of all the variables in the file
            List<FileVariable> variables = new List<FileVariable>();
            var matches = Regex.Matches(template, @"(?!(\[\[.*)){{ *\w+ *}}(?!(.*\]\]))");
            foreach (var match in matches) {
                var name = match.ToString().Replace("{{", "").Replace("}}", "").Trim();
                // see if this variable is already in the list
                if (!variables.Any(v => v.Tag.Equals(match.ToString()))) {
                    FileVariable fv = new FileVariable();
                    fv.Tag = match.ToString();
                    fv.Name = name;
                    variables.Add(fv);
                }
            }

            return variables;
        }

        public TemplateFileInfo GetTemplateInfo(string template) {
            TemplateFileInfo info = new TemplateFileInfo();
            info.Variables = GetVariables(template);
            info.CustomVariables = GetCustomVariables(template);
            return info;
        }

        public List<CustomVariable> GetCustomVariables(string template) {
            List<CustomVariable> variables = new List<CustomVariable>();
            var versionMatches = Regex.Matches(template, @"<CustomVariable(.|\n)+?>(.|\n)+?<\/CustomVariable>");
            foreach (var match in versionMatches) {
                string contents = match.ToString();
                XmlSerializer xml = new XmlSerializer(typeof(CustomVariable));
                var cv = (CustomVariable)xml.Deserialize(new StringReader(contents));               
                cv.RawElement = contents;
                variables.Add(cv);
            }

            return variables;
        }

        public Dictionary<string, string> getAttributes(string value) {
            var dict = new Dictionary<string, string>();
            var attrList = Regex.Matches(value, @"\w+=""[^""]+""");
            foreach (var match in attrList) {
                var values = match.ToString().Split('=');
                var data = values[1].Replace("\"", "");
                dict.Add(values[0], data);
            }

            return dict;
        }

        public string GetTagRegEx(string tagName) {
            return $"<{tagName}(.|\n)+>(.|\n)*</{tagName}>";
        }

        public void GetVersions(FileVariable fv) {
            // {{entity_field_list[[{{tab}}{{tab}}{{tab}}<v-><data_type:int,is_dto_field:true|int code>,<data_type : DateTime|DateTime code>, <default|default code><-v>{{nl}}]]}}
            fv.Versions = new List<TemplateVersion>();
            // see if there are multiple versions of the template
            // (old) var verMatch = Regex.Match(fv.InnerTemplate, "<v->.+<-v>");
            var verMatch = Regex.Match(fv.InnerTemplate, "<v->(.|\n)+<-v>");
            if (verMatch.Success) {
                var versions = Regex.Matches(fv.InnerTemplate, @"< *( *\w+ *: *\w+ *,?|default)* *\| *([^>])+ *>");
                if (versions.Count > 0) {
                    // parse each type
                    foreach (var version in versions) {
                        TemplateVersion ver = new TemplateVersion();
                        // get the parameters first
                        var parameters = Regex.Matches(version.ToString(), @"(\w+ *: *\w+ *)");
                        if (parameters.Count > 0) {
                            foreach (var p in parameters) {
                                string[] parts = p.ToString().Split(':');
                                //ver.Parameters.Add(parts[0].Trim(), parts[1].Trim());
                            }
                        } else {
                            // this must be the default version
                            ver.IsDefault = true;
                        }

                        // get the template
                        ver.Template = getInBetween(version.ToString(), "|", ">");                        
                        fv.Versions.Add(ver);
                    }
                }

                // replace the versions with a tag
                fv.InnerTemplate = fv.InnerTemplate.Replace(verMatch.ToString(), "{{template_versions}}");
            }
        }

        private string getInBetween(string value, string startChar, string endChar) {
            // find the start char
            int start = value.IndexOf(startChar) + startChar.Length;
            int endPos = value.IndexOf(endChar, start);
            int length = endPos - start;
            return value.Substring(start, length);
        }

        public string GenerateCode(GenerateCodeOptions opt, string templatePath) {
            // first load the file
            string template = File.ReadAllText(templatePath);
            return GenerateCodeFromTemplate(opt, template);
        }

        public string GenerateCodeFromTemplate(GenerateCodeOptions opt, string template) {
            // get all the variables 
            var info = GetTemplateInfo(template);
            // go through all of the versioned mappings
            foreach (var map in mapper.CustomMappings) {
                template = ReplaceIfExistsVersioned(info.CustomVariables, opt, map, template);
            }

            // go through all of the mappings
            foreach (var map in mapper.Mappings) {
                // see if this tag exists in the code
                template = ReplaceIfExists(info.Variables, opt, map, template);
            }

            return template;
        }

        string ReplaceIfExists(List<FileVariable> variables, GenerateCodeOptions opt, TagMapping mapping, string code) {
            // see if this variable exists in the list
            var list = variables.Where(v => v.Name == mapping.TagName).ToList();
            if (list.Count > 0) {
                // get the value
                string value = mapping.Result(opt, list[0]);
                list.ForEach(v => code = code.Replace(v.Tag, value));
                // replace basics
                code = code.Replace("[@tab]", "\t");
                return code;
            }

            return code;
        }

        string ReplaceIfExistsVersioned(List<CustomVariable> variables, GenerateCodeOptions opt, CustomTagMapping mapping, string code) {
            // see if this variable exists in the list
            var list = variables.Where(v => v.Tag == mapping.TagName).ToList();
            foreach (var v in list) {
                // get the value
                string value = mapping.Result(opt, v);
                code = code.Replace(v.RawElement, value);                
            }

            return code;
        }

        string ReplaceIfExists(List<FileVariable> variables, string variableName, string value, string code) {
            // see if this variable exists in the list
            var list = variables.Where(v => v.Name == variableName).ToList();
            if (list.Count > 0) {
                list.ForEach(v => code = code.Replace(v.Tag, value));
                return code;
            }

            return code;
        }

        public string GetProjectPath(Project proj, string projectType, string languageType) {
            if (projectType == ProjectTypes.Logic && languageType == LanguageTypes.DotNet) {
                return proj.DotNetLogicProjectPath;
            } else if (projectType == ProjectTypes.API && languageType == LanguageTypes.DotNet) {
                return proj.DotNetAPIProjectPath;
            }

            return "";
        }

        public string GetEntityFields(GenerateCodeOptions opt, CustomVariable variable) {
            string code = "";
            foreach (var field in opt.Entity.Fields) {
                string template = variable.Template;
                // add tabs if necessary
                if (variable.Tabs > 0) {
                    template = Repeat("\t", variable.Tabs) + template;
                }

                // make sure it meets the criteria
                if (!variable.IsSearchField || field.IsSearchField) {
                    bool shouldInclude = true;
                    // see if this variable has variables
                    if (variable.Versions != null && variable.Versions.Count > 0) {
                        // figure out this field matches a version
                        TemplateVersion fieldVersion = null;
                        shouldInclude = false;
                        foreach (var version in variable.Versions) {
                            if ((string.IsNullOrEmpty(version.DataType) || field.DataType == version.DataType) &&
                                (!version.IsContainsSearch || field.IsContainsSearch)) {
                                fieldVersion = version;
                                break;
                            }
                        }

                        if (fieldVersion != null) {
                            template = !string.IsNullOrEmpty(template) ? template.Replace("{{version}}", fieldVersion.Template) : fieldVersion.Template;
                            shouldInclude = true;
                        } else {
                            // see if there is a default version
                            var defList = variable.Versions.Where(v => v.IsDefault).ToList();
                            if (defList.Count > 0) {
                                // use the default version
                                template = !string.IsNullOrEmpty(template) ? template.Replace("{{version}}", defList[0].Template) : defList[0].Template;
                                shouldInclude = true;
                            }
                        }
                    }

                    if (shouldInclude) {
                        // see if we need to add a seperator
                        if (!string.IsNullOrEmpty(code) && !string.IsNullOrEmpty(variable.Seperator)) {
                            code += variable.Seperator;
                        }

                        var innerVars = GetVariables(template);
                        template = ReplaceIfExists(innerVars, Tags.Entity.EntityFieldName, field.FieldName, template);

                        // see if the data type should be nullable
                        string dataType = field.DataType;
                        if (variable.Nullable) {
                            dataType = GetNullableDataType(field.DataType);    
                        }

                        template = ReplaceIfExists(innerVars, Tags.Entity.EntityFieldDataType, dataType, template);
                        code += template;
                    }
                }
            }

            // replace any basic values the template might have
            code = GenerateCodeFromTemplate(opt, code);
            return code;
        }

        protected virtual string GetNullableDataType(string dataType) {
            return dataType;
        }

        string Repeat(string value, int total) {
            string finalVal = string.Empty;
            for (int x = 0; x < total; x++) {
                finalVal += value;
            }

            return finalVal;
        }
    }
}
