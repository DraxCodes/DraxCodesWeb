using DraxCodesWeb.Services.Entities;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace DraxCodesWeb.Services
{
    public class TodoJsonStorage
    {
        public string ConvertJson(object obj)
        {
            return JsonConvert.SerializeObject(obj, Formatting.Indented);
        }

        public List<TodoItem> LoadItems(string path)
        {
            var json = File.ReadAllText(path);
            if(string.IsNullOrWhiteSpace(json)) { return null; }
            return JsonConvert.DeserializeObject<List<TodoItem>>(json);
        }
    }
}
