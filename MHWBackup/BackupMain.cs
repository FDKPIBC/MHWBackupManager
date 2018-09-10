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

        public Setting Setting;

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
            labHash.Text = _currentBackup.FileHash;
            labCreateTime.Text = _currentBackup.CreateTime.ToString("yyyy年MM月dd日 hh:mm");
            tableLayoutPanel1.Visible = true;
        }

        private void lbHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbHistory.SelectedIndex < 0) return;
            _currentBackup = BackupManager.Backups.FirstOrDefault(t => t.FileHash == lbHistory.SelectedItem.ToString());
            ReloadLayout(false);
        }

        private void tsmiBackup_Click(object sender, EventArgs e)
        {
            _currentBackup = BackupManager.CreateNewBackup();
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
                lbHistory.Items.Add(backup.FileHash);
            }
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
            new About().ShowDialog();
        }
    }
}
