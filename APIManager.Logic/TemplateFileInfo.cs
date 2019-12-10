using System;
using System.Collections.Generic;
using System.Text;

namespace APIManager.Logic {
    public class TemplateFileInfo {
        public List<FileVariable> Variables { get; set; }
        public List<CustomVariable> CustomVariables { get; set; }
    }
}
