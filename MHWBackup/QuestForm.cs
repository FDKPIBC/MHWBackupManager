using MHWBackup.Utils;
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
    public partial class QuestForm : Form
    {
        private QuestManager questManager;

        private Label label;

        public QuestForm()
        {
            InitializeComponent();
            questManager = new QuestManager();
            ShowOrHide();
            Task.Factory.StartNew(()=>questManager.LoadQuest()).ContinueWith(t=> ReloadLayout());
        }
        
        private void ShowOrHide()
        {
            if (label == null)
            {
                label = new Label() { Visible = false };
                label.Text = "当前加载中...";
                label.Font = new Font("黑体",12);
                label.Width = 120;
                label.Location = new Point((int)(Width/2  - (12*5.5)),this.Height/2 - 30);
                this.Controls.Add(label);
            }
            if (label.Visible)
            {
                flpNews.Visible = true;
                label.Visible = false;
            }
            else
            {
                flpNews.Visible = false;
                label.Visible = true;
            }
        }
        
        private void ReloadLayout()
        {
            this.Invoke(new Action(() =>
            {
                ShowOrHide();
                foreach (var quest in questManager.Quests)
                {
                    var questItem = new QuestItem(quest);
                    flpNews.Controls.Add(questItem);
                }
            }));
        }
    }
}
