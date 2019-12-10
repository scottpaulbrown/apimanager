using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace APIManager.Logic {
    public class CustomVariable {
        public CustomVariable() {
            Versions = new List<TemplateVersion>();
        }

        public string RawElement { get; set; }
        public string Template { get; set; }
        public string Seperator { get; set; }
        [XmlAttribute(attributeName:"tag")]
        public string Tag { get; set; }
        [XmlAttribute(attributeName:"isSearchField")]
        public bool IsSearchField { get; set; }
        [XmlAttribute(attributeName: "isNotKey")]
        public bool IsNotKey { get; set; }
        [XmlAttribute(attributeName: "isDTOField")]
        public bool IsDTOField { get; set; }
        [XmlAttribute(attributeName: "tabs")]
        public int Tabs { get; set; }
        [XmlAttribute(attributeName: "nullable")]
        public bool Nullable { get; set; }
        public List<TemplateVersion> Versions { get; set; }
    }
}
