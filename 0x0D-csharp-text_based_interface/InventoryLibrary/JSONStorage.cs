using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace InventoryLibrary
{
    public class JSONStorage
    {
        private Dictionary<string, object> objects;
        private string storagePath;

        public JSONStorage(string storagePath)
        {
            this.storagePath = storagePath;
            objects = new Dictionary<string, object>();
        }

        public Dictionary<string, object> All()
        {
            return objects;
        }

        public void New(object obj)
        {
            string key = $"{obj.GetType().Name}.{GetId(obj)}";
            objects[key] = obj;
        }

        public void Save()
        {
            string json = JsonSerializer.Serialize(objects);
            string filePath = Path.Combine(storagePath, "inventory_manager.json");
            File.WriteAllText(filePath, json);
        }

        public void Load()
        {
            string filePath = Path.Combine(storagePath, "inventory_manager.json");
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                objects = JsonSerializer.Deserialize<Dictionary<string, object>>(json);
            }
        }

        private string GetId(object obj)
        {
            var property = obj.GetType().GetProperty("Id");
            return property?.GetValue(obj)?.ToString() ?? throw new ArgumentException("Object must have an Id property.");
        }
    }
}
