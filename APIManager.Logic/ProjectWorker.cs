using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace APIManager.Logic {
    public class ProjectWorker {
       public void CommitRevision(Project proj, Revision revision) {
            DBWorker dbWorker = new DBWorker();
            dbWorker.ExecuteRevision(proj, revision);
           
        }
    }
}
