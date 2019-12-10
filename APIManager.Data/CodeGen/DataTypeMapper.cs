using APIManager.Data.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace APIManager.Data.CodeGen {
    public static class DataTypeMapper {
        private static List<DataTypeMapping> _mappings = new List<DataTypeMapping>() {
            new DataTypeMapping(DataTypes.String, DBDataTypes.VarChar),
            new DataTypeMapping(DataTypes.String, DBDataTypes.Char),
            new DataTypeMapping(DataTypes.Int, DBDataTypes.Integer),
            new DataTypeMapping(DataTypes.DateTime, DBDataTypes.DateTime),
            new DataTypeMapping(DataTypes.DateTime, DBDataTypes.DateTime2),
            new DataTypeMapping(DataTypes.Decimal, DBDataTypes.Decimal)
        };

        public static string getDBDataType(EntityField field) {
            // find the correct mapping
            var mapping = _mappings.Where(m => m.DataTypeCode == field.Datatype).First();
            return mapping.DBDataType;
        }
    }
}
