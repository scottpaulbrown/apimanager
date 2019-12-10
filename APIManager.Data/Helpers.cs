using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

namespace APIManager.Data {
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

        public static void WriteJson<T>(T obj, string path) {
            MemoryStream stream = new MemoryStream();
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(T));
            ser.WriteObject(stream, obj);
            string json = Encoding.UTF8.GetString(stream.ToArray());
            File.WriteAllText(path, json);
        }

        public static T OpenJson<T>(string path) {
            string contents = File.ReadAllText(path);
            MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes(contents));
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(T));
            T obj = (T)ser.ReadObject(stream);
            return obj;
        }
    }
}
