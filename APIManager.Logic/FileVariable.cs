using System;
using System.Collections.Generic;
using System.Text;

namespace APIManager.Logic {
    public class FileVariable {
        public string Name { get; set; }
        public string Tag { get; set; }
        public string Value { get; set; }
        public string InnerTemplate { get; set; }

        public List<TemplateVersion> Versions { get; set; }
    }
}
