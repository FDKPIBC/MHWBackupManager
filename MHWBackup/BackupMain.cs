using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MHWBackup
{
    public partial class BackupMain : Form
    {
        public BackupManager BackupManager;

        private Backup _currentBackup;

        public BackupMain()
        {
            BackupManager = new BackupManager();
            InitializeComponent();
            InitForm();
        }

        private void InitForm()
        {
            BackupManager.LoadBackupHistory();
            if (BackupManager.Backups.Count>0)
            {
                _currentBackup = BackupManager.Backups.FirstOrDefault();
                ReloadLayout();
            }
            HidePanel();
            if (BackupManager.CurrentUser == null)
            {
                return;
            }
            this.Text = "当前用户:" + BackupManager.CurrentUser.UserName;
        }

        private void HidePanel()
        {
            tableLayoutPanel1.Visible = false;
            labSteamId.Text =
            labHash.Text =
            labCreateTime.Text = string.Empty;
        }

        private void ReloadLayout(bool reloadList = true)
        {
            if (reloadList)
            {
                RefreshListBox();
            }
            labSteamId.Text = _currentBackup.SteamId;
            labHash.Text = _currentBackup.SHA1;
            labCreateTime.Text = _currentBackup.CreateTime.ToString("yyyy年MM月dd日 hh:mm");
            tableLayoutPanel1.Visible = true;
        }

        private void lbHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbHistory.SelectedIndex < 0) return;
            var value = (KeyValuePair<string, string>)lbHistory.SelectedItem;
            _currentBackup = BackupManager.Backups.FirstOrDefault(t => t.SHA1 == value.Key);
            ReloadLayout(false);
        }

        private void tsmiBackup_Click(object sender, EventArgs e)
        {
            var newBackup = BackupManager.CreateNewBackup();
            if (newBackup == null)
            {
                return;
            }
            _currentBackup = newBackup;
            ReloadLayout();
        }

        private void btnReduction_Click(object sender, EventArgs e)
        {
            MessageBox.Show("请勿运行游戏时还原备份!");
            BackupManager.ReductionBackup(_currentBackup.Path);
        }


        private void RefreshListBox()
        {
            lbHistory.Items.Clear();
            foreach (var backup in BackupManager.Backups)
            {
                lbHistory.Items.Add(new KeyValuePair<string,string>(backup.SHA1,backup.CreateTime.ToString("yyyy-MM-dd hh:mm:ss")));
            }
            lbHistory.DisplayMember = "Value";
            lbHistory.ValueMember = "Key";
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            BackupManager.RemoveBackup(_currentBackup);
            if (BackupManager.Backups.Count > 0)
            {
                _currentBackup = BackupManager.Backups.FirstOrDefault();
                ReloadLayout();
            }
            else
            {
                lbHistory.Items.Clear();
                HidePanel();
            }
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new About().Show();
        }

        private void 修复桌面快捷方式ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.CreateShortcut();
        }

        private void 活动表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var quest = new QuestForm();
            quest.Show();
        }
    }
}
