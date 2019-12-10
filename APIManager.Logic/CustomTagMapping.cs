using System;
using System.Collections.Generic;
using System.Text;

namespace APIManager.Logic {
    public class CustomTagMapping {
        public CustomTagMapping(string tag, Func<GenerateCodeOptions, CustomVariable, string> result) {
            TagName = tag;
            Result = result;
        }

        public string TagName { get; set; }
        public Func<GenerateCodeOptions, CustomVariable, string> Result { get; set; }
    }
}
