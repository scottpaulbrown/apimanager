using System;
using System.Collections.Generic;
using System.Text;

namespace APIManager.Logic {
    public class TagMapper {
        public List<TagMapping> Mappings { get; set; }
        public List<CustomTagMapping> CustomMappings { get; set; }

        public TagMapper() {
            Mappings = new List<TagMapping>();
            CustomMappings = new List<CustomTagMapping>();
        }

        public void AddMapping(string tagName, Func<GenerateCodeOptions, FileVariable, string> result, TagMappingType mappingType, string genCode) {
            Mappings.Add(new TagMapping(tagName, result, mappingType, genCode));
        }

        public void AddMapping(string tagName, Func<GenerateCodeOptions, FileVariable, string> result, TagMappingType mappingType) {
            Mappings.Add(new TagMapping(tagName, result, mappingType));
        }

        public void AddMapping(string tagName, Func<GenerateCodeOptions, FileVariable, string> result) {
            Mappings.Add(new TagMapping(tagName, result));
        }

        public void AddCustomMapping(string tagName, Func<GenerateCodeOptions, CustomVariable, string> result) {
            CustomMappings.Add(new CustomTagMapping(tagName, result));
        }
    }
}
