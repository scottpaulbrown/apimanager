using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace APIManager.WIN {
    [DataContract]
    public class AppData {
        [DataMember]
        public string DefaultSavePath { get; set; }
        [DataMember]
        public List<string> RecentProjects { get; set; }
        [DataMember]
        public List<ProjectInfo> RecentProjectList { get; set; }
        [DataMember]
        public string TemplatePath { get; set; }

        public AppData() {
            this.RecentProjects = new List<string>();
        }
    }
}
