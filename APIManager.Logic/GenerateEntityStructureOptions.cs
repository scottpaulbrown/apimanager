using System;
using System.Collections.Generic;
using System.Text;

namespace APIManager.Logic {
    public class GenerateEntityStructureOptions {
        public Project Project { get; set; }
        public EntityInfo Entity { get; set; }
        public string TemplatePath { get; set; }
    }
}
