using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gameloop.Vdf;
using Microsoft.Win32;
using System.IO;
using System.Windows.Forms;
using Gameloop.Vdf.Linq;

namespace MHWBackup
{
    public class SteamUserManager
    {
        public List<SteamUser> SteamUsers { get; set; }

        public SteamUserManager()
        {
            SteamUsers = new List<SteamUser>();
            LoadSteamUser();
        }

        public string GetSteamBaseDir()
        {
            var steamPath = (string)Registry.GetValue(@"HKEY_CURRENT_USER\Software\Valve\Steam", "SteamPath", "");
            if (steamPath.IsEmpty())
            {

                if (MessageBox.Show("未找到您的steam目录,是否手动选择?", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var fbd = new FolderBrowserDialog();
                    fbd.Description = "仅选择steam根目录即可!";
                    if (fbd.ShowDialog() == DialogResult.Yes)
                    {
                        if (fbd.SelectedPath.IsEmpty()) throw new Exception("未找到对应的steam目录!");
                        steamPath = fbd.SelectedPath;
                    }
                    else throw new Exception("未找到对应的steam目录!");
                }
                else
                {
                    throw new Exception("未找到对应的steam目录!");
                }
            }
            steamPath = Path.Combine(steamPath,"userdata");
            if (!steamPath.PathIsExist()) throw new Exception("steam目录下无userdata!");
            return steamPath;
        }

        private void LoadSteamUser()
        {
            var steamPath = GetSteamBaseDir();
            var userdir = Directory.GetDirectories(steamPath);
            foreach (var dir in userdir)
            {
                var config = Path.Combine(dir,"config", "localconfig.vdf");
                var vdf = VdfConvert.Deserialize(File.ReadAllText(config));
                SteamUsers.Add(new SteamUser()
                {
                    UserName = vdf.Value["friends"].Value<string>("PersonaName"),
                    UserBaseDir = dir,
                    GameDir = dir.ToGameDictionary()
                });
            }
        }
    }
}
