using System;
using System.Collections.Generic;
using System.Text;

namespace APIManager.Logic {
    public class APIRequestLogic {
        public static List<DataField> GetFieldsFromEntifyInfo(EntityInfo info) {
            var list = new List<DataField>();
            info.Fields.ForEach(f => list.Add(new DataField() { FieldName = f.FieldName, DataType = f.DataType }));
            return list;
        }
    }
}
