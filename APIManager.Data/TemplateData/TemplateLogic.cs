using APIManager.Data.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIManager.Data.TemplateData {
    public class TemplateLogic : LogicBase {
        public TemplateLogic(AppInfo appInfo) : base(appInfo) {
        }

        public List<Template> SearchTemplates(SearchTemplatesArgs args) {
            return _appInfo.Context.Templates.ToList();
        }

        public void CreateTemplate(Template template) {
            _appInfo.Context.Templates.Add(template);
            _appInfo.Context.SaveChanges();
        }

        public void UpdateTemplate(Template template) {
            if (template.DeletedEntities != null && template.DeletedEntities.Count > 0) {
                _appInfo.Context.TemplateEntityAttributes.RemoveRange(template.DeletedEntities);
            }

            _appInfo.Context.SaveChanges();
        }

        public List<TemplateGroup> SearchTemplateGroups(SearchTemplateGroupsArgs args) {
            return _appInfo.Context.TemplateGroups.ToList();
        }

        public void CreateTemplateGroup(TemplateGroup group) {
            _appInfo.Context.TemplateGroups.Add(group);
            _appInfo.Context.SaveChanges();
        }

        public void UpdateTemplateGroup(TemplateGroup group) {
            if (group.DeletedMembers != null && group.DeletedMembers.Count > 0) {
                _appInfo.Context.TemplateGroupMembers.RemoveRange(group.DeletedMembers);
            }

            _appInfo.Context.SaveChanges();
        }
    }
}
