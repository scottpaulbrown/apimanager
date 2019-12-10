using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace APIManager.Logic {
    [DataContract]
    public class Revision {
        public Revision() {
            EntityRevisions = new List<EntityRevision>();
        }

        [DataMember]
        public string RevisionName { get; set; }
        [DataMember]
        public DateTime BeginDate { get; set; }
        [DataMember]
        public string Status { get; set; }
        [DataMember]
        public List<EntityRevision> EntityRevisions { get; set; }
    }
}
