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
    public partial class ChoosePlayer : Form
    {
        public SteamUser Choosed { get; set; }

        public ChoosePlayer(SteamUserManager steamUserManager)
        {
            InitializeComponent();
            lbUserList.DataSource = steamUserManager.SteamUsers;
            lbUserList.DisplayMember = "UserName";
        }

        private void lbUserList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lbUserList.SelectedIndex < 0) return;
            Choosed = lbUserList.SelectedItem as SteamUser;
            this.DialogResult = DialogResult.OK;
        }
    }
}
