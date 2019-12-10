using System;
using System.Collections.Generic;
using System.Text;

namespace APIManager.Logic {
    public class GenerateCodeOptions {
        public EntityInfo Entity { get; set; }
        public Project Project { get; set; }
        public string TemplatePath { get; set; }
    }
}
