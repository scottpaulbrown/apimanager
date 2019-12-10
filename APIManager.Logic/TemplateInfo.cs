using System;
using System.Collections.Generic;
using System.Text;

namespace APIManager.Logic {
    public class TemplateInfo {
        public TemplateInfo(TemplateFile template) {
            Template = template;
            GenerateTemplate = true;
        }

        public TemplateInfo(bool generateTemplate, TemplateFile template) {
            GenerateTemplate = generateTemplate;
            Template = template;
        }

        public bool GenerateTemplate { get; set; }
        public TemplateFile Template { get; set; }        
    }
}
