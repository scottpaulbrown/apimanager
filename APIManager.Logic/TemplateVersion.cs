using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace APIManager.Logic {
    public class TemplateVersion {
        [XmlText]
        public string Template { get; set; }
        [XmlAttribute(attributeName:"isDefault")]
        public bool IsDefault { get; set; }       
        [XmlAttribute(attributeName:"dataType")]
        public string DataType { get; set; }
        [XmlAttribute(attributeName: "isContainsSearch")]
        public bool IsContainsSearch { get; set; }
    }
}
