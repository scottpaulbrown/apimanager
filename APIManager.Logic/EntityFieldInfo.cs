using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace APIManager.Logic {
    [DataContract]
    public class EntityFieldInfo {
        [DataMember]
        public int EntityFieldId { get; set; }
        [DataMember] 
        public int EntityId { get; set; }
        [DataMember]
        public string FieldName { get; set; }
        [DataMember]
        public string DataType { get; set; }
        [DataMember]
        public bool IsSearchField { get; set; }
        [DataMember]
        public bool IsContainsSearch { get; set; }
        [DataMember]
        public bool IsDTOField { get; set; }
        [DataMember]
        public int Scale { get; set; }
        [DataMember]
        public int MaxLength { get; set; }
        [DataMember]
        public bool IsKey { get; set; }
        [DataMember]
        public bool IsIdentity { get; set; }
        [DataMember]
        public bool IsRequired { get; set; }
        [DataMember] 
        public string StatusCode { get; set; }
    }
}
