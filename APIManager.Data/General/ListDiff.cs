using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIManager.Data.General {
    public class ListDiff<T> {
        public List<T> NewEntries { get; set; }
        public List<T> DeletedEntries { get; set; }

        public ListDiff() {
            NewEntries = new List<T>();
            DeletedEntries = new List<T>();
        }
    }
}
