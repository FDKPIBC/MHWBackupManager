namespace MHWBackup
{
    partial class BackupMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackupMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiBackup = new System.Windows.Forms.ToolStripMenuItem();
            this.活动表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修复桌面快捷方式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labSaveTime = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labSteamId = new System.Windows.Forms.Label();
            this.labHash = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReduction = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lbHistory = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labCreateTime = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiBackup,
            this.活动表ToolStripMenuItem,
            this.设置ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(472, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiBackup
            // 
            this.tsmiBackup.Name = "tsmiBackup";
            this.tsmiBackup.Size = new System.Drawing.Size(44, 21);
            this.tsmiBackup.Text = "备份";
            this.tsmiBackup.Click += new System.EventHandler(this.tsmiBackup_Click);
            // 
            // 活动表ToolStripMenuItem
            // 
            this.活动表ToolStripMenuItem.Name = "活动表ToolStripMenuItem";
            this.活动表ToolStripMenuItem.Size = new System.Drawing.Size(56, 21);
            this.活动表ToolStripMenuItem.Text = "活动表";
            this.活动表ToolStripMenuItem.Click += new System.EventHandler(this.活动表ToolStripMenuItem_Click);
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.修复桌面快捷方式ToolStripMenuItem});
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.设置ToolStripMenuItem.Text = "设置";
            // 
            // 修复桌面快捷方式ToolStripMenuItem
            // 
            this.修复桌面快捷方式ToolStripMenuItem.Name = "修复桌面快捷方式ToolStripMenuItem";
            this.修复桌面快捷方式ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.修复桌面快捷方式ToolStripMenuItem.Text = "修复桌面快捷方式";
            this.修复桌面快捷方式ToolStripMenuItem.Click += new System.EventHandler(this.修复桌面快捷方式ToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.labSteamId, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labHash, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnReduction, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnRemove, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labSaveTime, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labCreateTime, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(139, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(333, 234);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.Visible = false;
            // 
            // labSaveTime
            // 
            this.labSaveTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labSaveTime.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.labSaveTime, 2);
            this.labSaveTime.Location = new System.Drawing.Point(64, 109);
            this.labSaveTime.Name = "labSaveTime";
            this.labSaveTime.Size = new System.Drawing.Size(266, 12);
            this.labSaveTime.TabIndex = 5;
            this.labSaveTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Location = new System.Drawing.Point(3, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "存档时间";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labSteamId
            // 
            this.labSteamId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labSteamId.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.labSteamId, 2);
            this.labSteamId.Location = new System.Drawing.Point(64, 17);
            this.labSteamId.Name = "labSteamId";
            this.labSteamId.Size = new System.Drawing.Size(266, 12);
            this.labSteamId.TabIndex = 1;
            this.labSteamId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labHash
            // 
            this.labHash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labHash.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.labHash, 2);
            this.labHash.Location = new System.Drawing.Point(64, 63);
            this.labHash.Name = "labHash";
            this.labHash.Size = new System.Drawing.Size(266, 12);
            this.labHash.TabIndex = 3;
            this.labHash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "SteamId";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Location = new System.Drawing.Point(3, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "SHA1";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReduction
            // 
            this.btnReduction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReduction.Location = new System.Drawing.Point(64, 193);
            this.btnReduction.Name = "btnReduction";
            this.btnReduction.Size = new System.Drawing.Size(130, 31);
            this.btnReduction.TabIndex = 6;
            this.btnReduction.Text = "还原备份";
            this.btnReduction.UseVisualStyleBackColor = true;
            this.btnReduction.Click += new System.EventHandler(this.btnReduction_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.Location = new System.Drawing.Point(200, 193);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(130, 31);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "删除备份";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lbHistory
            // 
            this.lbHistory.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbHistory.FormattingEnabled = true;
            this.lbHistory.ItemHeight = 12;
            this.lbHistory.Location = new System.Drawing.Point(0, 25);
            this.lbHistory.Name = "lbHistory";
            this.lbHistory.Size = new System.Drawing.Size(139, 234);
            this.lbHistory.TabIndex = 3;
            this.lbHistory.SelectedIndexChanged += new System.EventHandler(this.lbHistory_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Location = new System.Drawing.Point(3, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "备份时间";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labCreateTime
            // 
            this.labCreateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labCreateTime.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.labCreateTime, 2);
            this.labCreateTime.Location = new System.Drawing.Point(64, 155);
            this.labCreateTime.Name = "labCreateTime";
            this.labCreateTime.Size = new System.Drawing.Size(266, 12);
            this.labCreateTime.TabIndex = 9;
            this.labCreateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BackupMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 259);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lbHistory);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BackupMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "备份工具";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiBackup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox lbHistory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labSaveTime;
        private System.Windows.Forms.Label labSteamId;
        private System.Windows.Forms.Label labHash;
        private System.Windows.Forms.Button btnReduction;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修复桌面快捷方式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 活动表ToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labCreateTime;
    }
}

