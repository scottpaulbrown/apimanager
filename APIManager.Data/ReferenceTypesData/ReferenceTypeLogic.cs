using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APIManager.Data.General;

namespace APIManager.Data.ReferenceTypesData {
    public class ReferenceTypeLogic : LogicBase {
        public ReferenceTypeLogic(AppInfo appInfo) : base(appInfo) {
        }

        public List<DataType> GetAllDataTypes() {
            return _db.DataTypes.ToList();
        }

        public List<LinkType> GetAllLinkTypes() {
            return _db.LinkTypes.ToList();
        }

        public List<LanguageType> GetAllLanguageTypes() {
            return _db.LanguageTypes.ToList();
        }

        public List<CodeProjectType> GetAllCodeProjectTypes() {
            return _db.CodeProjectTypes.ToList();
        }

        public List<EntityAttributeType> GetAllEntityAttributeTypes() {
            return _db.EntityAttributeTypes.ToList();
        }
    }
}
