using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APIManager.Data.General;

namespace APIManager.Data.ProjectData {
    public class ProjectLogic : LogicBase {
        public ProjectLogic(AppInfo appInfo) : base(appInfo) {
        }

        public Project GetProject(int id) {            
            var proj = _db.Projects.Where(p => p.ProjectId == id).First();
            return proj;
        }
    }
}
