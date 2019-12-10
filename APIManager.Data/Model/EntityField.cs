using APIManager.Data.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIManager.Data {
    public partial class EntityField : IEntityField {
        [NotMapped]
        public bool IsDeleted { get; set; }
    }
}
