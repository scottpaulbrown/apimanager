using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace APIManager.Logic {
    public class TemplateWorker {
        public static List<FileVariable> GetVariables(string template) {
            // get a list of all the variables in the file
            List<FileVariable> variables = new List<FileVariable>();
            var matches = Regex.Matches(template, @"{{ *\w+ *}}");
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

        public static string GenerateCode(GenerateCodeOptions opt, string templatePath) {
            // first load the file
            string template = File.ReadAllText(templatePath);
            return GenerateCodeFromTemplate(opt, template);
        }

        public static string GenerateCodeFromTemplate(GenerateCodeOptions opt, string template) {
            //// get all the variables 
            //var variables = TemplateWorker.GetVariables(template);
            //// go through all of the mappings
            //foreach (var map in opt.Mapper.Mappings) {
            //    // see if this tag exists in the code
            //    template = ReplaceIfExists(variables, opt, map, template);
            //}

            return template;
        }

        static string  ReplaceIfExists(List<FileVariable> variables, GenerateCodeOptions opt, TagMapping mapping, string code) {
            //// see if this variable exists in the list
            //var list = variables.Where(v => v.Name == mapping.TagName).ToList();
            //if (list.Count > 0) {
            //    // get the value
            //    string value = mapping.Result(opt, code);
            //    list.ForEach(v => code = code.Replace(v.Tag, value));
            //    // replace basics
            //    code = code.Replace("[@tab]", "\t");
            //    return code;
            //}

            return code;
        }

        static string ReplaceIfExists(List<FileVariable> variables, string variableName, string value, string code) {
            // see if this variable exists in the list
            var list = variables.Where(v => v.Name == variableName).ToList();
            if (list.Count > 0) {
                list.ForEach(v => code = code.Replace(v.Tag, value));
                return code;
            }

            return code;
        }

        public static string GetProjectPath(Project proj, string projectType, string languageType) {
            if (projectType == ProjectTypes.Logic && languageType == LanguageTypes.DotNet) {
                return proj.DotNetLogicProjectPath;
            } else if (projectType == ProjectTypes.API && languageType == LanguageTypes.DotNet) {
                return proj.DotNetAPIProjectPath;
            }

            return "";
        }
    }
}
