using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIManager.Data.RevisionData {
    public class AddRevisionChangesArgs {
        public int ProjectId { get; set; }
        public List<Entity> EntityList { get; set; }
        public List<Entity> ImportedList { get; set; }
    }
}
