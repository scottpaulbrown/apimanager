using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace APIManager.Logic {
    [DataContract]
    public class Project {
        [DataMember]
        public string ProjectName { get; set; }
        [DataMember]
        public List<ProjectService> Services { get; set; }
        [DataMember]
        public List<EntityInfo> Entities { get; set; }
        [DataMember]
        public string DotNetAPIProjectPath { get; set; }
        [DataMember]
        public string DotNetLogicProjectPath { get; set; }
        [DataMember]
        public string DatabaseProjectPath { get; set; }
        [DataMember]
        public string DotNetNamespace { get; set; }
        [DataMember]
        public List<Revision> Revisions { get; set; }

        public Project() {
            Services = new List<ProjectService>();
            Entities = new List<EntityInfo>();
            Revisions = new List<Revision>();
        }
    }
}
