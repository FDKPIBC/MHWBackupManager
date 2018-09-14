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
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            richTextBox1.LoadFile("ChangeLog.rtf");
        }
    }
}
