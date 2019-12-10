using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace APIManager.Logic {
    public class DBWorker {
        public void ExecuteRevision(Project proj, Revision revision) {
            string script = string.Empty;
            string downScript = string.Empty;

            // first create script for each entity revision
            foreach (var eRev in revision.EntityRevisions) {
                if (eRev.EntityRevisionTypeCode == EntityRevisionTypeCodes.Add) {
                    // find the entity
                    var entity = proj.Entities.Where(e => e.EntityId == eRev.EntityId).First();
                    string addScript = GenerateCreateTableScript(entity);
                    if (script != string.Empty) { script += "\n\n"; }
                    script += addScript;
                    // now put in the drop script
                    if (downScript != string.Empty) { downScript += "\n\n"; }
                    downScript += $"DROP TABLE [{entity.EntityName}];";
                }
            }

            // create the migration script
            string fileName = GenerateMigrationScript(proj, revision);
            string migrationScript = script;
            // add the down portion
            migrationScript += "\n-- //@UNDO\n";
            migrationScript += downScript;
            // write and execute the script
            string scriptPath = Path.Combine(proj.DatabaseProjectPath, "Scripts", fileName);
            File.WriteAllText(scriptPath, migrationScript);
            ExecuteMigrateUp(proj);
        }

        public string GenerateMigrationScript(Project proj, Revision revision) {
            Directory.SetCurrentDirectory(proj.DatabaseProjectPath);
            string fileName = revision.RevisionName.Replace(" ", "_");
            Helpers.ExecuteProcess("migrate.cmd", $"new {fileName}");
            // now find the new file
            var fileList = Directory.GetFiles(Path.Combine(proj.DatabaseProjectPath, "Scripts"), $"*_{fileName}.sql");
            return fileList[0];
        }

        public void ExecuteMigrateUp(Project proj, string environmentName="local") {
            Directory.SetCurrentDirectory(proj.DatabaseProjectPath);
            Helpers.ExecuteProcess("migrate.cmd", $"up --env={environmentName}");           
        }

        public string GenerateCreateTableScript(EntityInfo entity) {
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
            foreach (var field in entity.Fields) {
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

        public static string GetColumnDef(EntityFieldInfo fieldInfo) {
            var dt = DataTypeMapper.getDBDataType(fieldInfo);
            var def = $"[{fieldInfo.FieldName}] {dt}";
            if (fieldInfo.IsIdentity) {
                def += " IDENTITY(1,1)";
            }

            if (fieldInfo.IsRequired) {
                def += " NOT NULL";
            } else {
                def += " NULL";
            }

            return def;
        }
    }
}
