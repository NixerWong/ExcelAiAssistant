using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using ExcelAiAssistant.Models;

namespace ExcelAiAssistant.Components
{
    public class ConfigHelper
    {
        public static List<Config> LoadModelConfigFromFile(string filePath, bool onlyEnable = false)
        {
            Properties.Settings st = new Properties.Settings();
            if (File.Exists(filePath))
            {
                var json = File.ReadAllText(filePath);
                if(onlyEnable)
                {
                    var cfgs = JsonConvert.DeserializeObject<List<Config>>(json)?.Where(c => c.Enabled == "Y").OrderBy(c => c.ModelId).ToList();
                    return cfgs;
                }
                else
                {
                    var cfgs = JsonConvert.DeserializeObject<List<Config>>(json)?.OrderBy(c => c.ModelId).ToList();
                    return cfgs;
                }
            }
            return new List<Config>();
        }

        public static void SaveModelConfigToFile(List<Config> configs, string filePath)
        {
            Properties.Settings st = new Properties.Settings();
            var sortedConfigs = configs.OrderBy(c => c.ModelId).ToList();
            var outputJson = JsonConvert.SerializeObject(sortedConfigs, Formatting.Indented);
            File.WriteAllText(filePath, outputJson);
        }
    }
}
