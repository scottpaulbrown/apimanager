using System;
using System.Collections.Generic;
using System.Text;

namespace APIManager.Logic {
    public enum TagMappingType {  Simple, SubScript };

    public class TagMapping {
        public string TagName { get; set; }
        public Func<GenerateCodeOptions, FileVariable, string> Result { get; set; }
        public TagMappingType MappingType { get; set; }
        public string GenCode { get; set; }
        
        public TagMapping(string tagName, Func<GenerateCodeOptions, FileVariable, string> result, TagMappingType mappingType, string genCode) {
            TagName = tagName;
            Result = result;
            MappingType = mappingType;
            GenCode = genCode;
        }

        public TagMapping(string tagName, Func<GenerateCodeOptions, FileVariable, string> result, TagMappingType mappingType) {
            TagName = tagName;
            Result = result;
            MappingType = mappingType;
        }

        public TagMapping(string tagName, Func<GenerateCodeOptions, FileVariable, string> result) {
            TagName = tagName;
            Result = result;
        }
    }
}
