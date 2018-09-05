using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace ChangeStats {
    public class Config {
        public Dictionary<int, int> userLoginHP = new Dictionary<int, int>();

        public void Write(string path) {
            File.WriteAllText(path, JsonConvert.SerializeObject(this, Formatting.Indented));
        }

        public static Config Read(string path) {
            if (!File.Exists(path))
                return new Config();
            return JsonConvert.DeserializeObject<Config>(File.ReadAllText(path));
        }
    }
}
