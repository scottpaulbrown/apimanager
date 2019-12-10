using System;
using System.Collections.Generic;
using System.Text;

namespace APIManager.Logic {
    public class APIRequest {
        public string Name { get; set; }
        public string RequestType { get; set; }
        public string Path { get; set; }
        public List<DataField> Parameters { get; set; }

        public APIRequest() {
            Parameters = new List<DataField>();
        }
    }
}
