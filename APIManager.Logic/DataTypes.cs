using System;
using System.Collections.Generic;
using System.Text;

namespace APIManager.Logic {
    public class DataTypes {
        public static List<DataType> GetList() {
            return new List<DataType>() {
                new DataType(String, true, false),
                new DataType(DateTime),
                new DataType(Bool),
                new DataType(Decimal, true, true),
                new DataType(Long),
                new DataType(Int)
            };
        }

        public const string String = "string";
        public const string DateTime = "DateTime";
        public const string Int = "int";
        public const string Decimal = "decimal";
        public const string Long = "long";
        public const string Bool = "bool";
    }
}
