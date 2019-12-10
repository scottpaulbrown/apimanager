using System;
using System.Collections.Generic;
using System.Text;

namespace APIManager.Logic {
    public class TemplateGroup {
        public string Name { get; set; }
        public List<TemplateInfo> Templates { get; set; }

        public TemplateGroup() {
            Templates = new List<TemplateInfo>();
        }
    }
}
