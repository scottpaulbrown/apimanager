using System;
using System.Collections.Generic;
using System.Text;

namespace APIManager.Logic {
    public class InnerTemplate {
        public string Template { get; set; }
        public List<TemplateVersion> Versions { get; set; }
    }
}
