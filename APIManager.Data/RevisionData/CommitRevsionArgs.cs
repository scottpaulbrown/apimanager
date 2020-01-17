using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIManager.Data.RevisionData {
    public class CommitRevsionArgs {
        public int RevisionId { get; set; }
        public bool ExcuteMigration { get; set; }
        public Revision Revision { get; set; }
    }
}
