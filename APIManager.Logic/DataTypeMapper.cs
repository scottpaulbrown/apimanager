using System;
using System.Collections.Generic;
using System.Text;

namespace APIManager.Logic {
    public class DataTypeMapper {
        public static string getDBDataType(EntityFieldInfo field) {
            switch (field.DataType) {
                case DataTypes.String:
                    string length = field.MaxLength > 0 ? field.MaxLength.ToString() : "max";
                    return $"varchar({length})";
                case DataTypes.Decimal:
                    return $"decimal({field.MaxLength}, {field.Scale})";
                default:
                    return field.DataType;
            }
        }
    }
}
