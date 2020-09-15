using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
namespace JobsAbility
{
    static class Config
    {
        private static Dictionary<string, string> dic = new Dictionary<string, string>();
        static Config()
        {
            var dicpath = Path.Combine(Directory.GetCurrentDirectory(), "config.json");
            var dicStr = File.ReadAllText(dicpath);
            dic = JsonConvert.DeserializeObject<Dictionary<string, string>>(dicStr);
        }
        public static string GetValue(string key)
        {
            try
            {
                if (dic.ContainsKey(key))
                {
                    return dic[key];
                }
                return null;
            }
            catch (Exception)
            {
                return null; 
            }
        }
    }
}
