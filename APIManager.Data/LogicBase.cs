using APIManager.Data.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIManager.Data {
    public abstract class LogicBase {
        protected AppInfo _appInfo;
        protected ProjManEntities _db;

        protected LogicBase(AppInfo appInfo) {
            _appInfo = appInfo;
            if (appInfo.Context != null) {
                _db = appInfo.Context;
            } else {
                _db = new ProjManEntities();
            }
        }
    }
}
