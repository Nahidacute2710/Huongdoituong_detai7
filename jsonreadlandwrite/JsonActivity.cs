using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.IO;
using System.Threading.Tasks;
using OOP_De_tai_7.DataManagerClass;

namespace OOP_De_tai_7.modal
{
    public static class JsonActivity
    {
        public static void WriteToJsonFile(string path, DataManager data)
        {
            string json = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true, IncludeFields = true });
            File.WriteAllText(path, json);
        }
        public static DataManager ReadFromJsonFile(string path)
        {
            if (!File.Exists(path))
            {
                return new DataManager();
            }
            string json= File.ReadAllText(path);
            return JsonSerializer.Deserialize<DataManager>(json);
        }
    }
}
