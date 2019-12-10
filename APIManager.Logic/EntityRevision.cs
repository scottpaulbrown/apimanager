using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace APIManager.Logic {
    [DataContract]
    public class EntityRevision {
        [DataMember]
        public int EntityId { get; set; }
        [DataMember]
        public string EntityRevisionTypeCode { get; set; }
    }
}
