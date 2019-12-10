using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace APIManager.Logic {
    [DataContract]
    public class EntityLink {
        [DataMember]
        public int EntityFieldId { get; set; }
        public string EntityFieldName { get; set; }
        [DataMember]
        public int LinkedEntityId { get; set; }
        public string LinkedEntityName { get; set; }
        [DataMember]
        public int LinkedFieldId { get; set; }
        public string LinkedFieldName { get; set; }
        [DataMember]
        public string LinkType { get; set; }
    }
}
