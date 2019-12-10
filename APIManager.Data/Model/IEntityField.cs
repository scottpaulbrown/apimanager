using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIManager.Data.Model {
    public interface IEntityField {
        string FieldName { get; set; }
        string Datatype { get; set; }
        bool IsSearchField { get; set; }
        bool IsRequired { get; set; }
        bool IsContainsSearch { get; set; }
        bool IsDTO { get; set; }
        bool IsKey { get; set; }
    }
}
