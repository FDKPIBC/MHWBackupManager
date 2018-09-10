using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ionic.Zip;
using Microsoft.Win32;
using Newtonsoft.Json;

namespace MHWBackup
{
    public class BackupManager
    {
        private SteamUserManager _steamUserManager;

        public SteamUser CurrentUser { get; private set; }

        public static string BackupPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "backup");

        /// <summary>
        /// 备份记录集合
        /// </summary>
        public List<Backup> Backups { get; set; }

        public BackupManager()
        {
            _steamUserManager = new SteamUserManager();
            if (_steamUserManager.SteamUsers.Count > 1)
            {
                using (var cpForm = new ChoosePlayer(_steamUserManager))
                {
                    if (cpForm.ShowDialog() == DialogResult.OK)
                    {
                        CurrentUser = cpForm.Choosed;
                    }
                    else
                    {
                        MessageBox.Show("猛汉好聚好散,告辞!");
                        Application.ExitThread();
                    }
                }
            }
            else
            {
                CurrentUser = _steamUserManager.SteamUsers.FirstOrDefault();
            }
        }

        /// <summary>
        /// 加载备份
        /// </summary>
        public void LoadBackupHistory()
        {
            Backups = new List<Backup>();
            if (!Directory.Exists(BackupPath))
            {
                Directory.CreateDirectory(BackupPath);
                return;
            }
            var historyPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "history.conf");
            if (!File.Exists(historyPath)) return;
            Backups = JsonConvert.DeserializeObject<List<Backup>>(File.ReadAllText(historyPath)).Where(t => t.SteamId == CurrentUser.SteamId).ToList();
        }

        public Backup CreateNewBackup()
        {
            if (!CurrentUser.GameDir.TryGetValue("582010", out string gamepath))
            {
                MessageBox.Show("您选择的steam账号应该不是一个猛汉吧!");
                return null;
            }
            if (!gamepath.PathIsExist())
            {
                MessageBox.Show("您选择的steam账号应该不是一个猛汉吧!");
                return null;
            }
            var backup = new Backup();
            backup.CreateTime = DateTime.Now;
            backup.SteamName = CurrentUser.UserName;
            backup.SteamId = CurrentUser.SteamId;
            using (var zip = new ZipFile())
            {
                zip.AddDirectory(gamepath);
                backup.FileHash = zip.GetHashCode().ToString();
                backup.Path = Path.Combine(BackupPath, Guid.NewGuid().ToString() + ".zip");
                zip.Save(backup.Path);
            }
            Backups.Add(backup);
            Backups = Backups.OrderBy(t => t.CreateTime).ToList();
            return backup;
        }

        public void ReductionBackup(string filename)
        {
            CurrentUser.GameDir.TryGetValue("582010", out string gamepath);
            var zip = ZipFile.Read(filename);
            zip.ExtractAll(gamepath, ExtractExistingFileAction.OverwriteSilently);
        }

        /// <summary>
        /// 保存备份历史记录
        /// </summary>
        public void SaveBackupHistory()
        {
            var historyPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "history.conf");
            var json = JsonConvert.SerializeObject(Backups);
            File.WriteAllText(historyPath,json);
        }

        public void RemoveBackup(Backup backup)
        {
            File.Delete(backup.Path);
            Backups.Remove(backup);
        }
    }
}
