using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

namespace APIManager.Logic {
    public class FileTools {
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
