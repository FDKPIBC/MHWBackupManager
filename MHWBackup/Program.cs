using IWshRuntimeLibrary;
using MHWBackup.Utils;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MHWBackup
{
    static class Program
    {
        public static Setting Setting { get; set; }

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Setting = Setting.LoadConfig();
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += Application_ThreadException;
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            //var questmanager = new QuestManager();
            //questmanager.LoadQuest();
            var backupMain = new BackupMain();
            if (!CheckShortcutExist()&&Program.Setting.IsFirstLaunch)
            {
                if (MessageBox.Show("猛汉您的桌面未找到本程序的快捷方式,是否创建以提升狩猎体验?", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    CreateShortcut();
                }
                else
                {
                    Setting.IsFirstLaunch = false;
                }
            }
            Application.ApplicationExit += (sender, e) =>
            {
                backupMain.BackupManager.SaveBackupHistory();
                Setting.SaveConfig();
            };
            if (backupMain.BackupManager.CurrentUser != null)
            {
                Application.Run(backupMain);
            }
        }

        public static bool CheckShortcutExist()
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
        public static void CreateShortcut()
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

        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            WriteExceptionLog(e.Exception);
        }

        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            var ex = e.ExceptionObject as Exception;
            if (ex != null) WriteExceptionLog(ex);
        }

        static void WriteExceptionLog(Exception ex)
        {
            if (ex == null) return;
            MessageBox.Show("程序运行异常,即将关闭,详情请查看错误日志!");
            var sb = new StringBuilder();
            sb.AppendLine($"-----------{DateTime.Now:yyyy/MM/dd hh:mm:ss}----------");
            sb.AppendLine($"StackTrace:{ex.InnerException?.StackTrace ?? ex.StackTrace}");
            sb.AppendLine();
            sb.AppendLine($"Message:{ex.InnerException?.Message ?? ex.Message}");
            sb.AppendLine($"------------------------------------------");
            if (!Setting.LogPath.PathIsExist()) Directory.CreateDirectory(Setting.LogPath);
            var exlogpath = Path.Combine(Setting.LogPath, DateTime.Now.ToString("yyyyMMdd") + ".exception");
            System.IO.File.AppendAllText(exlogpath, sb.ToString());
            Application.Exit();
        }
    }
}
