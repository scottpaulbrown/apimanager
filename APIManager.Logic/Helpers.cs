using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace APIManager.Logic {
    public class Helpers {
        public static int GenerateUniqueId(Func<int, bool> duplicateCheck) {
            int id;
            bool isDup;
            var ranGen = new Random();

            do {
                id = ranGen.Next();
                isDup = duplicateCheck(id);
            } while (isDup);

            return id;
        }

        public static void ExecuteProcess(string executablePath, string args) {
            using (Process proc = new Process()) {
                proc.StartInfo.UseShellExecute = true;
                proc.StartInfo.FileName = executablePath;
                proc.StartInfo.Arguments = args;
                proc.Start();
                proc.WaitForExit();
            }
        }
    }
}
