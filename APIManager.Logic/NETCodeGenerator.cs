using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace APIManager.Logic {
    public class NETCodeGenerator : GenericCodeGenerator {
        public NETCodeGenerator() {
           
        }

        protected override string GetNullableDataType(string dataType) {
            string[] nonNullables = { "string" };
            if (!nonNullables.Contains(dataType)) {
                return $"{dataType}?";
            } else {
                return dataType;
            }
        }
    }
}
