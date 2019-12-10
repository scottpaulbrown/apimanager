using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIManager.Data.General {
    public class AppInfo {
        public string TemplatePath { get; set; }
        public ProjManEntities Context { get; set; }
    }
}
