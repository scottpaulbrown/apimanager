using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace APIManager.Logic {
    public class AssemblyLogic {
        public EntityInfo GetEntityFromClassFile(string path) {
            EntityInfo info = new EntityInfo();
            string code = File.ReadAllText(path);
            // find the class name
            var classCode = Regex.Match(code, @"\bpublic\b +(\bpartial \b)*\bclass\b +\w*");
            if (!classCode.Success) {
                throw new Exception("This file is not a valid c# class");
            }

            // isolate the class name
            string classLine = classCode.ToString();
            int index = classLine.IndexOf("class") + 5;
            info.EntityName = classLine.Substring(index).Trim();
            var props = Regex.Matches(code, @"\bpublic\b +\w+ +\w* *{ *get; *set; *}");
            foreach (var prop in props) {
                var fieldInfo = GetFieldInfo(prop.ToString());
                info.Fields.Add(fieldInfo);
            }

            return info;
        }

        private EntityFieldInfo GetFieldInfo(string code) {
            // replace all white space with pipes
            string[] parts = Regex.Replace(code, @" +", "|").Split('|');
            EntityFieldInfo info = new EntityFieldInfo();
            info.FieldName = parts[2];
            info.DataType = parts[1];
            return info;
        }
    }
}
