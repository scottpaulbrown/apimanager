using System;
using System.Collections.Generic;
using System.Text;

namespace APIManager.Logic {
    public class DataType {
        public DataType(string dataTypeCode) {
            DataTypeCode = dataTypeCode;
        }

        public DataType(string dataTypeCode, bool requiresMaxLength, bool requiresScale) : this(dataTypeCode) {
            RequiresMaxLength = requiresMaxLength;
            RequiresScale = requiresScale;
        }

        public string DataTypeCode { get; set; }
        public bool RequiresMaxLength { get; set; }
        public bool RequiresScale { get; set; }
    }
}
