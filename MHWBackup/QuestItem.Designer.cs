namespace MHWBackup
{
    partial class QuestItem
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.labTitle = new System.Windows.Forms.Label();
            this.labTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labMap = new System.Windows.Forms.Label();
            this.labContent = new System.Windows.Forms.Label();
            this.labQuestT = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbImage
            // 
            this.pbImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbImage.Location = new System.Drawing.Point(4, 14);
            this.pbImage.Name = "pbImage";
            this.tableLayoutPanel1.SetRowSpan(this.pbImage, 3);
            this.pbImage.Size = new System.Drawing.Size(72, 72);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // labTitle
            // 
            this.labTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labTitle.AutoSize = true;
            this.labTitle.Location = new System.Drawing.Point(83, 10);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(35, 12);
            this.labTitle.TabIndex = 1;
            this.labTitle.Text = "Title";
            // 
            // labTime
            // 
            this.labTime.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labTime.AutoSize = true;
            this.labTime.Location = new System.Drawing.Point(286, 10);
            this.labTime.Name = "labTime";
            this.labTime.Size = new System.Drawing.Size(191, 12);
            this.labTime.TabIndex = 2;
            this.labTime.Text = "2018/9/14 00:00-2018/9/15 00:00";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "地图:";
            // 
            // labMap
            // 
            this.labMap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labMap.AutoSize = true;
            this.labMap.Location = new System.Drawing.Point(124, 43);
            this.labMap.Name = "labMap";
            this.labMap.Size = new System.Drawing.Size(41, 12);
            this.labMap.TabIndex = 4;
            this.labMap.Text = "label2";
            // 
            // labContent
            // 
            this.labContent.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labContent.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.labContent, 3);
            this.labContent.Location = new System.Drawing.Point(83, 77);
            this.labContent.Name = "labContent";
            this.labContent.Size = new System.Drawing.Size(41, 12);
            this.labContent.TabIndex = 5;
            this.labContent.Text = "label2";
            // 
            // labQuestT
            // 
            this.labQuestT.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labQuestT.AutoSize = true;
            this.labQuestT.Location = new System.Drawing.Point(436, 43);
            this.labQuestT.Name = "labQuestT";
            this.labQuestT.Size = new System.Drawing.Size(41, 12);
            this.labQuestT.TabIndex = 6;
            this.labQuestT.Text = "label2";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.pbImage, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labQuestT, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.labTitle, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labTime, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.labContent, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labMap, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(480, 100);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // QuestItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "QuestItem";
            this.Size = new System.Drawing.Size(480, 100);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.Label labTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labMap;
        private System.Windows.Forms.Label labContent;
        private System.Windows.Forms.Label labQuestT;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
