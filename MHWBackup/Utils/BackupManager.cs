using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gameloop.Vdf;
using Ionic.Zip;
using MHWBackup.Utils;
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
            var dir = new DirectoryInfo(BackupPath);
            if (!dir.Exists)
            {
                dir.Create();
                dir.Attributes = FileAttributes.Hidden;
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
            if (!Comparison(gamepath, backup))
            {
                MessageBox.Show("您的文件已损坏,备份失败!");
                return null;
            }
            if (Backups.Any(t=>t.SHA1 == backup.SHA1))
            {
                MessageBox.Show("该记录已备份!");
                return null;
            }
            using (var zip = new ZipFile())
            {
                zip.AddDirectory(gamepath);
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

        /// <summary>
        /// 删除备份
        /// </summary>
        /// <param name="backup"></param>
        public void RemoveBackup(Backup backup)
        {
            File.Delete(backup.Path);
            Backups.Remove(backup);
        }

        public bool Comparison(string gamepath,Backup backup)
        {
            var savepath = Path.Combine(gamepath, "remotecache.vdf");
            var SAVEDATA1000 = VdfConvert.Deserialize(File.ReadAllText(savepath)).Value["SAVEDATA1000"];
            backup.Root = SAVEDATA1000.Value<string>("root");
            backup.Size = SAVEDATA1000.Value<long>("size");
            backup.LocalTime = new DateTime(1970, 1, 1, 0, 0, 0, 0).AddSeconds(SAVEDATA1000.Value<long>("localtime"));
            backup.Time = new DateTime(1970, 1, 1, 0, 0, 0, 0).AddSeconds(SAVEDATA1000.Value<long>("time"));
            backup.RemoteTime = new DateTime(1970, 1, 1, 0, 0, 0, 0).AddSeconds(SAVEDATA1000.Value<long>("remotetime"));
            backup.SHA1 = SAVEDATA1000.Value<string>("sha").ToUpper();
            backup.SyncState = SAVEDATA1000.Value<int>("syncstate");
            backup.PersistState = SAVEDATA1000.Value<int>("persiststate");
            backup.PlatformsToSync2 = SAVEDATA1000.Value<int>("platformstosync2");
            var sha1 = Path.Combine(gamepath, "remote", "SAVEDATA1000").GetSHA1().ToUpper();
            return sha1 == backup.SHA1;
        }
    }
}
