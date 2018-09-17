using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MHWBackup.Utils;

namespace MHWBackup
{
    public partial class QuestItem : UserControl
    {
        public QuestItem(Quest quest)
        {
            InitializeComponent();
            BindControl(quest);
        }

        private void BindControl(Quest quest)
        {
            labTitle.Text = quest.Title + " " + quest.LevelLimit;
            labQuestT.Text = quest.QuestTerms;
            labTime.Text = quest.TimeTerms;
            labMap.Text = "地图:" + quest.QuestMap;
            labeRequest.Text = quest.QuestRequest;
            labContent.Text = quest.Content;
            pbImage.ImageLocation = quest.Image;
        }
    }
}
