using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APIManager.Data.CodeGen;
using APIManager.Data.Constants;
using APIManager.Data.General;

namespace APIManager.Data.RevisionData {
    public class RevisionLogic : LogicBase {
        public RevisionLogic(AppInfo appInfo) : base(appInfo) {
        }

        public Revision BeginRevision(int projectId) {
            // make sure there isn't a revision already in progress
            if (_db.Revisions.Any(r => r.ProjectId == projectId && r.RevisionStatusCode == RevisionStatuses.InProgress)) {
                throw new Exception("There is already a revision in progress for this project");
            }

            // get the total number of revisions for this project
            var revCount = _db.Revisions.Where(r => r.ProjectId == projectId).Count();
            Revision rev = new Revision();
            rev.RevisionName = $"Revision #{revCount + 1}";
            rev.ProjectId = projectId;
            rev.BeginDate = DateTime.Now;
            rev.RevisionStatusCode = RevisionStatuses.InProgress;
            _db.Revisions.Add(rev);
            _db.SaveChanges();
            return rev;
        }

        public void AddRevisionChanges(AddRevisionChangesArgs args) {
            // get the active revision for this project
            var rev = _db.Revisions.Where(r => r.ProjectId == args.ProjectId && r.RevisionStatusCode == RevisionStatuses.InProgress).First();
            var list = args.EntityList.Select(e => new {
                entity = e,
                isImported = false
            }).ToList();

            if (args.ImportedList != null) {
                // add the imported entities
                list.AddRange(args.ImportedList.Select(e => new {
                    entity = e,
                    isImported = true
                }));
            }

            // determine the state of each entity
            foreach (var entry in list) {
                var entity = entry.entity;
                // see if this is a new entity
                if (entity.StatusCode == EntityStatusCodes.Staged && entity.EntityId == 0) {
                    // this entity needs to be added to the database
                    _db.Entities.Add(entity);
                    // a revision should be created for it
                    EntityChange ec = new EntityChange();
                    ec.RevisionId = rev.RevisionId;
                    ec.Entity = entity;
                    ec.ChangeTypeCode = entry.isImported ? EntityChangeTypes.Imported : EntityChangeTypes.Add;
                    ec.NewName = entity.EntityName;
                    rev.EntityChanges.Add(ec);                    
                } else if (entity.StatusCode == EntityStatusCodes.Staged) {
                    // just update the entity
                    _db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                    // see if there are new links
                    foreach (var field in entity.EntityFields) {
                        foreach (var link in field.ParentLinks) {
                            if (link.StatusCode == EntityLinkStatusCodes.Staged && link.EntityLinkId == 0) {
                                // create a link change record for this
                                LinkChange lc = new LinkChange();
                                lc.EntityLink = link;
                                lc.ChangeTypeCode = LinkChangeTypes.Add;
                                lc.RevisionId = rev.RevisionId;
                                rev.LinkChanges.Add(lc);
                            }
                        }
                    }
                } else if (entity.StatusCode == EntityStatusCodes.Active) {
                    // compare this version with the current version to see what has changed
                    CompareWithCurrent(entity, rev);
                }
            }

            _db.SaveChanges();
        }

        void CompareWithCurrent(Entity entity, Revision revision) {
            var current = _db.Entities.Where(e => e.EntityId == entity.EntityId).First();
            // compare the fields
            foreach (var field in entity.EntityFields) {                
                if (field.EntityFieldId > 0) {
                    // find the current field
                    var curField = current.EntityFields.Where(f => f.EntityFieldId == field.EntityFieldId).First();
                    if (field.IsDeleted) {
                        // make sure there isn't already a field change record for this
                        if (!revision.FieldChanges.Any(c => c.EntityFieldId == field.EntityFieldId && c.FieldChangeTypeCode == FieldChangeTypes.Deleted)) {
                            // create a entity field revision to mark the deletion
                            FieldChange fc = new FieldChange();
                            fc.EntityFieldId = field.EntityFieldId;
                            fc.RevisionId = revision.RevisionId;
                            fc.FieldChangeTypeCode = FieldChangeTypes.Deleted;
                            revision.FieldChanges.Add(fc);

                            // since this is being deleted, remove any other changes that are setup for this
                            var changeList = revision.FieldChanges.Where(c => c.EntityFieldId == field.EntityFieldId && c.FieldChangeTypeCode == FieldChangeTypes.Deleted).ToList();
                            changeList.ForEach(c => revision.FieldChanges.Remove(c));
                        }
                    }  else {                        
                        // see if this is a field that will be added or if it's a current field
                        if (field.StatusCode == EntityFieldStatusCodes.Staged) {
                            // just update the values that are different
                            curField.Datatype = field.Datatype;
                            curField.FieldName = field.FieldName;
                            curField.MaxLength = field.MaxLength;
                            curField.Scale = field.Scale;
                            curField.IsKey = field.IsKey;
                            curField.IsIdentity = field.IsIdentity;
                            curField.IsRequired = field.IsRequired;
                            curField.IsDTO = field.IsDTO;
                            curField.IsSearchField = field.IsSearchField;
                            curField.IsContainsSearch = field.IsContainsSearch;
                            curField.InitialValue = field.InitialValue;
                        } else {
                            if (!field.IsDeleted) {
                                // make sure this field wasn't previously listed as deleted
                                var fc = revision.FieldChanges.Where(c => c.EntityFieldId == field.EntityFieldId && c.FieldChangeTypeCode == FieldChangeTypes.Deleted).FirstOrDefault();
                                if (fc != null) {
                                    // un delete
                                    _db.FieldChanges.Remove(fc);
                                    field.IsDeleted = false;
                                    curField.IsDeleted = false;
                                }
                            }

                            // record any normal updates
                        }

                        // see if this field has any new links
                        if (field.ParentLinks != null && field.ParentLinks.Count > 0) {
                            foreach (var link in field.ParentLinks) {
                                // see if this is a new link
                                if (link.EntityLinkId == 0) {
                                    // add this link to the current version
                                    field.ParentLinks.Add(link);
                                    // create a link change record
                                    LinkChange change = new LinkChange();
                                    change.RevisionId = revision.RevisionId;
                                    change.EntityLink = link;
                                    change.ChangeTypeCode = LinkChangeTypes.Add;
                                    _db.LinkChanges.Add(change);
                                }
                            }
                        }

                        if (field.ChildLinks != null && field.ChildLinks.Count > 0) {
                            foreach (var link in field.ChildLinks) {
                                // see if this is a new link
                                if (link.EntityLinkId == 0) {
                                    // add this link to the current version
                                    field.ChildLinks.Add(link);
                                    // create a link change record
                                    LinkChange change = new LinkChange();
                                    change.RevisionId = revision.RevisionId;
                                    change.EntityLink = link;
                                    change.ChangeTypeCode = LinkChangeTypes.Add;
                                    _db.LinkChanges.Add(change);
                                }
                            }
                        }
                    }
                } else {
                    // this is a new field that needs to be added
                    current.EntityFields.Add(field);
                    // create a revision for this field
                    FieldChange fc = new FieldChange();
                    fc.FieldChangeTypeCode = FieldChangeTypes.Add;
                    fc.EntityField = field;
                    fc.RevisionId = revision.RevisionId;
                    _db.FieldChanges.Add(fc);
                }
            }
        }

        public void GenerateScript(int revisionId) {
            // get the revision
            var rev = _db.Revisions.Find(revisionId);
            // make sure it's in progress
            if (rev.RevisionStatusCode != RevisionStatuses.InProgress) {
                throw new Exception($"{rev.RevisionName} is not in progress");
            }

            // first update the database
            DBWorker dbWorker = new DBWorker();
            rev.ScriptFilename = dbWorker.ExecuteRevision(rev, true);
            _db.SaveChanges();
        }

        public void CommitRevision(int revisionId) {
            // get the revision
            var rev = _db.Revisions.Find(revisionId);
            // make sure it's in progress
            if (rev.RevisionStatusCode != RevisionStatuses.InProgress) {
                throw new Exception($"{rev.RevisionName} is not in progress");
            }

            // first update the database
            DBWorker dbWorker = new DBWorker();
            dbWorker.ExecuteRevision(rev);
            // udpate all of the entities
            foreach (var ec in rev.EntityChanges) {
                if (ec.ChangeTypeCode == EntityChangeTypes.Add || ec.ChangeTypeCode == EntityChangeTypes.Imported) {
                    ec.Entity.StatusCode = EntityStatusCodes.Active;
                    ec.Entity.EntityFields.ToList().ForEach(f => f.StatusCode = EntityFieldStatusCodes.Active);
                    ec.Entity.EntityFields.ToList().ForEach(f => f.ChildLinks.ToList().ForEach(l => l.StatusCode = EntityLinkStatusCodes.Active));
                    ec.Entity.EntityFields.ToList().ForEach(f => f.ParentLinks.ToList().ForEach(l => l.StatusCode = EntityLinkStatusCodes.Active));
                }                
            }

            rev.RevisionStatusCode = RevisionStatuses.Committed;
            rev.CommitDate = DateTime.Now;
            _db.SaveChanges();
        }
    }
}
