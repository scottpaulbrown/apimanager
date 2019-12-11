using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIManager.Data {
    public partial class EntityLink {
        public string PrimaryKeyFieldName { get; set; }
        public string ForeignKeyFieldName { get; set; }
        public string LinkTypeName { get; set; }
        public string PrimaryKeyEntityName { get; set; }
        public string ForeignKeyEntityName { get; set; }
    }
}
