using IWshRuntimeLibrary;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MHWBackup
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var backupMain = new BackupMain();
            if (!CheckShortcutExist()&&backupMain.BackupManager.Setting.IsFirstLaunch)
            {
                if (MessageBox.Show("猛汉您的桌面未找到本程序的快捷方式,是否创建以提升狩猎体验?", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    CreateShortcut();
                }
                else
                {
                    backupMain.BackupManager.Setting.IsFirstLaunch = false;
                }
            }
            Application.ApplicationExit += (sender, e) =>
            {
                backupMain.BackupManager.SaveBackupHistory();
                backupMain.BackupManager.Setting.SaveConfig();
            };
            if (backupMain.BackupManager.CurrentUser != null)
            {
                Application.Run(backupMain);
            }
        }

        static bool CheckShortcutExist()
        {
            String exePath = Process.GetCurrentProcess().MainModule.FileName;
            IWshShell shell = new WshShell();
            foreach (var item in Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), "*.lnk"))
            {
                WshShortcut tempShortcut = (WshShortcut)shell.CreateShortcut(item);
                if (tempShortcut.TargetPath == exePath)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// 创建桌面快捷方式
        /// 借鉴了某位老哥的代码地址:https://blog.csdn.net/luwq168/article/details/78969446
        /// </summary>
        static void CreateShortcut()
        {
            String shortcutPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), "猛汉王存档备份工具.lnk");
            if (!System.IO.File.Exists(shortcutPath))
            {
                String exePath = Process.GetCurrentProcess().MainModule.FileName;
                IWshShell shell = new WshShell();
                if (CheckShortcutExist()) return;
                WshShortcut shortcut = (WshShortcut)shell.CreateShortcut(shortcutPath);
                shortcut.TargetPath = exePath;
                shortcut.Arguments = "";// 参数  
                shortcut.Description = "狩猎之余别忘了备份哦!";
                shortcut.WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory;
                shortcut.IconLocation = exePath;
                shortcut.WindowStyle = 1;
                shortcut.Save();
            }
        }
    }
}
