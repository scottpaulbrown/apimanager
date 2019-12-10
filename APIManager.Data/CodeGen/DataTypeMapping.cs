using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIManager.Data.CodeGen {
    public class DataTypeMapping {
        public DataTypeMapping(string dataTypeCode, string dBDataType) {
            DataTypeCode = dataTypeCode;
            DBDataType = dBDataType;
        }

        public string DataTypeCode { get; set; }
        public string DBDataType { get; set; }
    }
}
