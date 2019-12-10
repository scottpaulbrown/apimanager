using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace APIManager.Logic {
    [DataContract]
    public class EntityInfo {
        [DataMember]
        public int EntityId { get; set; }
        [DataMember]
        public string EntityName { get; set; }
        [DataMember]
        public string StatusCode { get; set; }
        [DataMember]
        public List<EntityFieldInfo> Fields { get; set; }

        public EntityInfo() {
            Fields = new List<EntityFieldInfo>();
        }
    }
}
