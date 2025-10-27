using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.IO;
using System.Threading.Tasks;

namespace Test_Winform_detai7.modal
{
    public static class JsonActivity
    {
        public static void WriteToJsonFile<T>(string path, T data)
        {
            string json = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true, IncludeFields = true });
            File.WriteAllText(path, json);
        }
        public static List<T> ReadFromJsonFile<T>(string path)
        {
            try
            {
                if (!File.Exists(path))
                {
                    File.WriteAllText(path, "[]");
                    return new List<T>();
                }

                string json = File.ReadAllText(path);

                if (string.IsNullOrWhiteSpace(json))
                    return new List<T>();

                return JsonSerializer.Deserialize<List<T>>(json) ?? new List<T>();
            }
            catch (Exception)
            {
                return new List<T>();
            }
        }
    }
}
