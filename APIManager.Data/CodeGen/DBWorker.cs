using APIManager.Data.Constants;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;

namespace APIManager.Data.CodeGen {
    public class DBWorker {
        string databaseProjPath;

        public string ExecuteRevision(Revision revision, bool generateOnly = false) {
            string tableUpScript = string.Empty;
            string tableDownScript = string.Empty;
            string delColUpScript = string.Empty;
            string delColDownScript = string.Empty;
            string newColUpScript = string.Empty;
            string newColDownScript = string.Empty;
            string fkUpScript = string.Empty;
            string fkDownScript = string.Empty;
            int changeCount = 0;
            // find the database project path
            databaseProjPath = revision.Project.ProjectPaths.Where(p => p.PathTypeCode == PathTypes.DatabaseProject).First().Path;
            // first create script for each entity revision
            foreach (var eRev in revision.EntityChanges) {
                if (eRev.ChangeTypeCode == EntityChangeTypes.Add) {
                    // find the entity
                    var entity = revision.Project.Entities.Where(e => e.EntityId == eRev.EntityId).First();
                    string addScript = GenerateCreateTableScript(entity);
                    if (tableUpScript != string.Empty) { tableUpScript += "\n\n"; }
                    tableUpScript += addScript;
                    // now put in the drop script
                    if (tableDownScript != string.Empty) { tableDownScript += "\n\n"; }
                    tableDownScript += $"DROP TABLE [{entity.EntityName}];";
                    changeCount++;
                }
            }

            // look for deleted columns
            var delCols = revision.FieldChanges.Where(fc => fc.FieldChangeTypeCode == FieldChangeTypes.Deleted).ToList();
            if (delCols.Count > 0) {
                string delColPartOne = string.Empty;
                string delColPartOneDown = string.Empty;
                string delColPartTwo = string.Empty;
                string delColPartTwoDown = string.Empty;

                foreach (var fc in delCols) {
                    string entityName = fc.EntityField.Entity.EntityName;
                    delColPartTwo += GenerateDropColumnScript(entityName, fc.EntityField);
                    // see if this column has any keys
                    if (fc.EntityField.ParentLinks.Count > 0) {
                        // drop all of these links
                        foreach (var link in fc.EntityField.ParentLinks) {
                            delColPartOne = GenerateForeignKeyRollbackScript(link);
                            delColPartTwoDown = GenerateForeignKeyScript(link);
                        }
                    }
                    if (fc.EntityField.ChildLinks.Count > 0) {
                        // drop all of these links
                        foreach (var link in fc.EntityField.ChildLinks) {
                            delColPartOne = GenerateForeignKeyRollbackScript(link);
                            delColPartTwoDown = GenerateForeignKeyScript(link);
                        }
                    }
                    
                    changeCount++;
                }

                // create the entire down (re-create columns) script
                delColPartOneDown = GenerateFullNewColumnsScript(delCols);

                delColUpScript = GetWithLFIfNotNull(delColPartOne);
                delColUpScript += GetWithLFIfNotNull(delColPartTwo);
                delColDownScript = GetWithLFIfNotNull(delColPartOneDown);
                delColDownScript += GetWithLFIfNotNull(delColPartTwoDown);
            }

            // look for new columns
            var newCols = revision.FieldChanges.Where(fc => fc.FieldChangeTypeCode == FieldChangeTypes.Add).ToList();
            if (newCols.Count > 0) {
                // create the new column up script
                newColUpScript = GenerateFullNewColumnsScript(newCols);
                // add to the down script
                newCols.ForEach(c => newColDownScript += GenerateDropColumnScript(c.EntityField.Entity.EntityName, c.EntityField));
                changeCount += newCols.Count;
            }

            // look for new relationships
            foreach (var lRev in revision.LinkChanges) {
                if (lRev.ChangeTypeCode == LinkChangeTypes.Add) {
                    fkUpScript += GenerateForeignKeyScript(lRev.EntityLink);
                    fkDownScript += GenerateForeignKeyRollbackScript(lRev.EntityLink);
                    changeCount++;
                }
            }

            if (changeCount > 0) {
                // see if this revision already has script created
                string fileName = revision.ScriptFilename;
                if (string.IsNullOrEmpty(revision.ScriptFilename)) {
                    fileName = GenerateMigrationScript(revision.Project, revision);
                }
               
                string migrationScript = tableUpScript;
                migrationScript += delColUpScript;
                migrationScript += newColUpScript;
                migrationScript += fkUpScript;
                // add the down portion
                migrationScript += "\n-- //@UNDO\n";
                migrationScript += fkDownScript;
                migrationScript += newColDownScript;
                migrationScript += delColDownScript;
                migrationScript += tableDownScript;
                // write and execute the script
                string scriptPath = Path.Combine(databaseProjPath, "Scripts", fileName);
                File.WriteAllText(scriptPath, migrationScript);

                // determine if the script should be excecuted
                if (!generateOnly) {
                    ExecuteMigrateUp(revision.Project);
                }

                return fileName;
            }

            return string.Empty;
        }

        public string GenerateMigrationScript(Project proj, Revision revision) {
            Directory.SetCurrentDirectory(databaseProjPath);
            string fileName = revision.RevisionName.Replace(" ", "_");
            Helpers.ExecuteProcess("migrate.cmd", $"new {fileName}");
            // now find the new file
            var fileList = Directory.GetFiles(Path.Combine(databaseProjPath, "Scripts"), $"*_{fileName}.sql");
            return Path.GetFileName(fileList[0]);
        }

        public void ExecuteMigrateUp(Project proj, string environmentName="local") {
            Directory.SetCurrentDirectory(databaseProjPath);
            Helpers.ExecuteProcess("migrate.cmd", $"up --env={environmentName}");           
        }

        public string GenerateCreateTableScript(Entity entity) {
            string script = @"
CREATE TABLE [{table-name}] (
{column-list}

{primary-key-command}
);
";
            // replace the table name
            script = script.Replace("{table-name}", entity.EntityName);
            // replace the columns
            string cols = string.Empty;
            string keyCmd = string.Empty;
            foreach (var field in entity.EntityFields) {
                if (!string.IsNullOrEmpty(cols)) { cols += ",\r\n"; }
                var def = "\t" + GetColumnDef(field);
                // see if this is a primary key
                if (field.IsKey) {
                    keyCmd = $"\tCONSTRAINT [PK_{entity.EntityName}] PRIMARY KEY CLUSTERED ([{field.FieldName}] ASC)";
                }

                cols += def;
            }

            script = script.Replace("{column-list}", cols);
            script = script.Replace("{primary-key-command}", keyCmd);
            return script;
        }

        public string GenerateNewColumnScript(string tableName, EntityField field, bool overrideRequired = false) {
            return $"ALTER TABLE [{tableName}] ADD {GetColumnDef(field, overrideRequired)};\n";
        }

        public string GenerateDropColumnScript(string tableName, EntityField field) {
            return $"ALTER TABLE [{tableName}] DROP COLUMN [{field.FieldName}];\n";
        }

        public string CreateColumnUpdateScript(string entityName, List<EntityField> fields) {
            string colList = string.Empty;
            foreach (var field in fields) {
                if (!string.IsNullOrEmpty(colList)) { colList += ", "; }
                colList += $"[{field.FieldName}] = {field.InitialValue}";
            }

            return $"UPDATE [{entityName}] SET {colList};\n";
        }

        public string GetColumnDef(EntityField fieldInfo, bool overrideRequired = false) {
            var dt = GetFullDataType(fieldInfo);
            var def = $"[{fieldInfo.FieldName}] {dt}";
            if (fieldInfo.IsIdentity) {
                def += " IDENTITY(1,1)";
            }

            if (fieldInfo.IsRequired && !overrideRequired) {
                def += " NOT NULL";
            } else {
                def += " NULL";
            }

            return def;
        }

        public string GenerateForeignKeyScript(EntityLink link) {
            string table = link.ForeignKeyField.Entity.EntityName;
            string keyTable = link.PrimaryKeyField.Entity.EntityName;
            string columnName = link.ForeignKeyField.FieldName;
            string pkColumnName = link.PrimaryKeyField.FieldName;
            string sql = $"ALTER TABLE [{table}] WITH CHECK ADD CONSTRAINT [FK_{table}_{keyTable}] FOREIGN KEY([{columnName}]) REFERENCES [{keyTable}] ([{pkColumnName}]);\nALTER TABLE [{table}] CHECK CONSTRAINT [FK_{table}_{keyTable}];\n\r";
            return sql;
        }

        public string GenerateForeignKeyRollbackScript(EntityLink link) {
            string table = link.ForeignKeyField.Entity.EntityName;
            string keyTable = link.PrimaryKeyField.Entity.EntityName;
            string sql = $"ALTER TABLE [{table}] DROP CONSTRAINT [FK_{table}_{keyTable}];";
            return sql;
        }

        public string GenerateFullNewColumnsScript(List<FieldChange> newCols) {
            string script = string.Empty;
            string newColPartOne = string.Empty;
            string newColPartTwo = string.Empty;
            string newColPartThree = string.Empty;
            Dictionary<string, List<EntityField>> updateFields = new Dictionary<string, List<EntityField>>();
            foreach (var newCol in newCols) {
                string entityName = newCol.EntityField.Entity.EntityName;
                // see if the enitty is new or not
                if (newCol.EntityField.Entity.StatusCode == EntityStatusCodes.Active && newCol.EntityField.IsRequired) {
                    // since this table already exists and this field is marked as required, first we need to 
                    // add is as a nullable, set the value, then change it to a non nullable
                    newColPartOne += GenerateNewColumnScript(entityName, newCol.EntityField, true);
                    // now add to the fields for the update statement
                    if (!updateFields.ContainsKey(entityName)) {
                        updateFields.Add(entityName, new List<EntityField>());
                    }

                    updateFields[entityName].Add(newCol.EntityField);
                }

                newColPartThree += GenerateNewColumnScript(entityName, newCol.EntityField);
            }

            // see if an update script is needed
            if (updateFields.Count > 0) {
                foreach (var key in updateFields.Keys) {
                    newColPartTwo += CreateColumnUpdateScript(key, updateFields[key]);
                }
            }

            script = GetWithLFIfNotNull(newColPartOne);
            script += GetWithLFIfNotNull(newColPartTwo);
            script += GetWithLFIfNotNull(newColPartThree);
            return script;
        }

        public string GetFullDataType(EntityField field) {
            if (field.Datatype == DBDataTypes.Char || field.Datatype == DBDataTypes.VarChar) {
                return $"{field.Datatype}({field.MaxLength})";
            } else if (field.Datatype == DBDataTypes.Decimal) {
                return $"{field.Datatype}({field.MaxLength}, {field.Scale})";
            } else {
                return field.Datatype;
            }
        }

        public List<Entity> GetEntitiesFromDatabase(ProjectDatabase db) {
            List<Entity> list = new List<Entity>();
            string connString = CreateConnectionString(db);
            using (SqlConnection conn = new SqlConnection(connString)) {
                conn.Open();
                // first get the tables 
                string tableQ = "SELECT table_name FROM INFORMATION_SCHEMA.TABLES WHERE table_name NOT IN ('sysdiagrams', 'CHANGELOG') ORDER BY table_name";
                using (SqlCommand cmd = new SqlCommand(tableQ, conn)) {
                    using (SqlDataReader reader = cmd.ExecuteReader()) {
                        while (reader.Read()) {
                            Entity ent = new Entity();
                            ent.EntityFields = new List<EntityField>();
                            ent.EntityName = reader["table_name"].ToString();
                            ent.StatusCode = EntityStatusCodes.Staged;
                            list.Add(ent);
                        }
                    }
                }

                string fieldQ = "SELECT column_name, is_nullable, data_type, character_maximum_length, numeric_precision, numeric_scale FROM INFORMATION_SCHEMA.COLUMNS WHERE table_name = @TableName";
                using (SqlCommand fieldCmd = new SqlCommand(fieldQ, conn)) {
                    fieldCmd.Parameters.Add("@TableName", System.Data.SqlDbType.VarChar);
                    foreach (var entity in list) {
                        fieldCmd.Parameters["@TableName"].Value = entity.EntityName;
                        using (SqlDataReader fieldReader = fieldCmd.ExecuteReader()) {
                            while (fieldReader.Read()) {
                                EntityField field = new EntityField();
                                field.FieldName = fieldReader["column_name"].ToString();
                                field.Datatype = fieldReader["data_type"].ToString();
                                field.IsSearchField = true;
                                field.IsDTO = true;
                                field.IsRequired = fieldReader["is_nullable"].ToString().Equals("NO");
                                field.Scale = ValueOrNull(fieldReader["numeric_scale"]);
                                // setup the max length
                                if (IsStringType(field.Datatype)) {
                                    field.MaxLength = ValueOrNull(fieldReader["character_maximum_length"]);
                                } else if (field.Datatype == DBDataTypes.Decimal) {
                                    field.MaxLength = ValueOrNull(fieldReader["numeric_precision"]);
                                }

                                field.StatusCode = EntityFieldStatusCodes.Staged;
                                entity.EntityFields.Add(field);
                            }
                        }
                    }
                }

                // now get the primary key for each entity
                string keyQ = @"
SELECT		pkt.name, pkc.name AS ColumnName, pkc.is_identity AS IsIdentity

FROM		sys.indexes c
INNER JOIN	sys.tables pkt ON pkt.object_id = c.object_id
INNER JOIN	sys.index_columns ic ON ic.index_id = c.index_id AND ic.object_id = c.object_id
INNER JOIN	sys.columns pkc ON pkc.column_id = ic.column_id AND pkc.object_id = c.object_id

WHERE		c.is_primary_key = 1
AND			pkt.name = @TableName

";
                using (SqlCommand keyCmd = new SqlCommand(keyQ, conn)) {
                    keyCmd.Parameters.Add("@TableName", System.Data.SqlDbType.VarChar);
                    foreach (var entity in list) {
                        keyCmd.Parameters["@TableName"].Value = entity.EntityName;
                        using (SqlDataReader keyReader = keyCmd.ExecuteReader()) {
                            while (keyReader.Read()) {
                                string fieldName = keyReader["ColumnName"].ToString();
                                // find the field
                                var field = entity.EntityFields.Where(f => f.FieldName == fieldName).First();
                                field.IsKey = true;
                                field.IsIdentity = keyReader["IsIdentity"].ToString().Equals("True");
                            }
                        }
                    }
                }

                // now get all the foreign keys and match them up to the tables we've found
                string fkSql = @"

SELECT		fkt.name AS FKTable, fkcol.name AS FKColumn, pkt.name AS PKTable, pkcol.name AS PKColumn

FROM		sys.foreign_keys fk
INNER JOIN	sys.tables fkt ON fkt.object_id = fk.parent_object_id
INNER JOIN	sys.tables pkt ON pkt.object_id = fk.referenced_object_id
INNER JOIN	sys.foreign_key_columns fkc ON fkc.parent_object_id = fkt.object_id AND fkc.referenced_object_id = pkt.object_id
INNER JOIN	sys.columns fkcol ON fkcol.column_id = fkc.parent_column_id AND fkcol.object_id = fkc.parent_object_id
INNER JOIN	sys.columns pkcol ON pkcol.column_id = fkc.referenced_column_id AND pkcol.object_id = fkc.referenced_object_id

ORDER BY	fkt.name

";
                using (SqlCommand fkCmd = new SqlCommand(fkSql, conn)) {
                    using (SqlDataReader fkReader = fkCmd.ExecuteReader()) {
                        while (fkReader.Read()) {
                            // get the foreign key entity info
                            var fkEntityName = fkReader["FKTable"].ToString();
                            var fkFieldName = fkReader["FKColumn"].ToString();
                            var pkEntityName = fkReader["PKTable"].ToString();
                            var pkFieldName = fkReader["PKColumn"].ToString();
                            // see if this entity is in the list
                            var fkEntity = list.Where(e => e.EntityName == fkEntityName).FirstOrDefault();
                            // find the primary key entity
                            var pkEntity = list.Where(e => e.EntityName == pkEntityName).FirstOrDefault();
                            if (fkEntity != null && pkEntity != null) {
                                // find the field
                                var field = fkEntity.EntityFields.Where(f => f.FieldName == fkFieldName).First();
                                if (field.ParentLinks == null) { field.ParentLinks = new List<EntityLink>(); }
                                var pkField = pkEntity.EntityFields.Where(f => f.FieldName == pkFieldName).First();
                                // add an entity link for this entity
                                EntityLink link = new EntityLink();
                                link.StatusCode = EntityLinkStatusCodes.Staged;
                                field.ParentLinks.Add(link);
                                link.PrimaryKeyField = pkField;
                                // try to determine which type of link this is
                                if (pkFieldName.ToUpper().EndsWith("CODE") || pkFieldName.ToUpper().EndsWith("TYPE")) {
                                    link.LinkTypeCode = EntityLinkTypes.Reference;
                                } else {
                                    link.LinkTypeCode = EntityLinkTypes.Collection;
                                }
                            }
                        }
                    }
                }
            }

            return list;
        }

        string GetWithLFIfNotNull(string script) {
            if (!string.IsNullOrEmpty(script)) {
                return script + "\n";
            } else {
                return script;
            }
        }

        int? ValueOrNull(object val) {
            return val == DBNull.Value ? null : (int?)Convert.ToInt32(val);
        }

        bool IsStringType(string dataType) {
            return (dataType == DBDataTypes.Char || dataType == DBDataTypes.VarChar);
        }

        string CreateConnectionString(ProjectDatabase database) {
            return $"Data Source={database.ServerName};Initial Catalog={database.DatabaseName};Persist Security Info=True;User ID={database.Username};Password={database.Password}";
        }
    }
}
