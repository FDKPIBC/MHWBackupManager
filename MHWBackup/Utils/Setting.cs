using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MHWBackup
{
    public class Setting
    {
        public bool IsFirstLaunch { get; set; } = true;

        public string LogPath { get; set; } = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"log");

        public Setting()
        {

        }

        public static Setting LoadConfig()
        {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"config");
            if (!File.Exists(path)) return new Setting();
            return JsonConvert.DeserializeObject<Setting>(File.ReadAllText(path));
        }

        public void SaveConfig()
        {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config");
            File.WriteAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config"),JsonConvert.SerializeObject(this));
        }
    }
}
