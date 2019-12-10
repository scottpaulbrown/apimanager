using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APIManager.Data.Constants;
using APIManager.Data.General;

namespace APIManager.Data.EntityData {
    public class EntityLogic : LogicBase {
        public EntityLogic(AppInfo appInfo) : base(appInfo) { }

        public static Entity CopyEntity(Entity entity, Revision revision = null) {
            Entity copy = new Entity();
            copy.EntityId = entity.EntityId;
            copy.EntityName = entity.EntityName;
            copy.ProjectId = entity.ProjectId;
            copy.StatusCode = entity.StatusCode;
            copy.EntityFields = new List<EntityField>();
            // copy the fields
            foreach (var field in entity.EntityFields) {
                var fieldCopy = new EntityField();
                fieldCopy.EntityFieldId = field.EntityFieldId;
                fieldCopy.EntityId = field.EntityId;
                fieldCopy.FieldName = field.FieldName;
                fieldCopy.Datatype = field.Datatype;
                fieldCopy.MaxLength = field.MaxLength;
                fieldCopy.Scale = field.Scale;
                fieldCopy.IsKey = field.IsKey;
                fieldCopy.IsIdentity = field.IsIdentity;
                fieldCopy.IsRequired = field.IsRequired;
                fieldCopy.IsSearchField = field.IsSearchField;
                fieldCopy.IsContainsSearch = field.IsContainsSearch;
                fieldCopy.IsDTO = field.IsDTO;
                fieldCopy.StatusCode = field.StatusCode;
                fieldCopy.InitialValue = field.InitialValue;

                // see if this field has links
                if (field.ParentLinks.Count > 0) {
                    fieldCopy.ParentLinks = new List<EntityLink>();
                    foreach (var link in field.ParentLinks) {
                        fieldCopy.ParentLinks.Add(CopyLink(link));
                    }
                }

                if (field.ChildLinks.Count > 0) {
                    fieldCopy.ChildLinks = new List<EntityLink>();
                    foreach (var link in field.ChildLinks) {
                        fieldCopy.ChildLinks.Add(CopyLink(link));
                    }
                }

                // see if there are revisions for this field
                if (revision != null) {
                    var fcList = revision.FieldChanges.Where(c => c.EntityFieldId == field.EntityFieldId).ToList();
                    foreach (var fc in fcList) {
                        if (fc.FieldChangeTypeCode == FieldChangeTypes.Deleted) {
                            fieldCopy.IsDeleted = true;
                            break;
                        }
                    }
                }

                copy.EntityFields.Add(fieldCopy);
            }

            return copy;
        }

        public static EntityLink CopyLink(EntityLink link) {
            var copy = new EntityLink();
            copy.EntityLinkId = link.EntityLinkId;
            copy.ForeignKeyFieldId = link.ForeignKeyFieldId;
            copy.PrimaryKeyFieldId = link.PrimaryKeyFieldId;
            copy.StatusCode = link.StatusCode;
            copy.LinkTypeCode = link.LinkTypeCode;
            return copy;
        }
    }
}
