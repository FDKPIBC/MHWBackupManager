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
            this.labMap = new System.Windows.Forms.Label();
            this.labContent = new System.Windows.Forms.Label();
            this.labQuestT = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labeRequest = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbImage
            // 
            this.pbImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbImage.Location = new System.Drawing.Point(4, 14);
            this.pbImage.Name = "pbImage";
            this.tableLayoutPanel1.SetRowSpan(this.pbImage, 4);
            this.pbImage.Size = new System.Drawing.Size(72, 72);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // labTitle
            // 
            this.labTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labTitle.AutoSize = true;
            this.labTitle.Location = new System.Drawing.Point(83, 18);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(35, 12);
            this.labTitle.TabIndex = 1;
            this.labTitle.Text = "Title";
            // 
            // labTime
            // 
            this.labTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labTime.AutoSize = true;
            this.labTime.Location = new System.Drawing.Point(286, 18);
            this.labTime.Name = "labTime";
            this.labTime.Size = new System.Drawing.Size(191, 12);
            this.labTime.TabIndex = 2;
            this.labTime.Text = "2018/9/14 00:00-2018/9/15 00:00";
            // 
            // labMap
            // 
            this.labMap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labMap.AutoSize = true;
            this.labMap.Location = new System.Drawing.Point(83, 34);
            this.labMap.Name = "labMap";
            this.labMap.Size = new System.Drawing.Size(35, 12);
            this.labMap.TabIndex = 3;
            this.labMap.Text = "地图:";
            // 
            // labContent
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.labContent, 3);
            this.labContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labContent.Location = new System.Drawing.Point(83, 70);
            this.labContent.Name = "labContent";
            this.labContent.Size = new System.Drawing.Size(394, 30);
            this.labContent.TabIndex = 5;
            this.labContent.Text = "label2";
            // 
            // labQuestT
            // 
            this.labQuestT.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labQuestT.AutoSize = true;
            this.labQuestT.Location = new System.Drawing.Point(436, 34);
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
            this.tableLayoutPanel1.Controls.Add(this.labTitle, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labTime, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.labContent, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.labMap, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labQuestT, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.labeRequest, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(480, 100);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // labeRequest
            // 
            this.labeRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labeRequest.AutoSize = true;
            this.labeRequest.Location = new System.Drawing.Point(83, 54);
            this.labeRequest.Name = "labeRequest";
            this.labeRequest.Size = new System.Drawing.Size(35, 12);
            this.labeRequest.TabIndex = 7;
            this.labeRequest.Text = "要求:";
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
        private System.Windows.Forms.Label labMap;
        private System.Windows.Forms.Label labContent;
        private System.Windows.Forms.Label labQuestT;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labeRequest;
    }
}
