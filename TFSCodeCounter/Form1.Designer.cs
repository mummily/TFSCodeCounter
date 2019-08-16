namespace TFSCodeCounter
{
    partial class frmMain
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.grpBox_SearchCondtion = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lstView_SearchResult = new System.Windows.Forms.ListView();
            this.btnCounter = new System.Windows.Forms.Button();
            this.radioBtn_CheckAll = new System.Windows.Forms.RadioButton();
            this.radioBtn_CheckRev = new System.Windows.Forms.RadioButton();
            this.panel_RadioBtn = new System.Windows.Forms.Panel();
            this.grpBox_SearchCondtion.SuspendLayout();
            this.panel_RadioBtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBox_SearchCondtion
            // 
            this.grpBox_SearchCondtion.Controls.Add(this.btnSearch);
            this.grpBox_SearchCondtion.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpBox_SearchCondtion.Location = new System.Drawing.Point(0, 0);
            this.grpBox_SearchCondtion.Name = "grpBox_SearchCondtion";
            this.grpBox_SearchCondtion.Size = new System.Drawing.Size(1057, 88);
            this.grpBox_SearchCondtion.TabIndex = 0;
            this.grpBox_SearchCondtion.TabStop = false;
            this.grpBox_SearchCondtion.Text = "检索条件";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSearch.Location = new System.Drawing.Point(976, 59);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "检索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lstView_SearchResult
            // 
            this.lstView_SearchResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstView_SearchResult.CheckBoxes = true;
            this.lstView_SearchResult.Location = new System.Drawing.Point(0, 117);
            this.lstView_SearchResult.Name = "lstView_SearchResult";
            this.lstView_SearchResult.Size = new System.Drawing.Size(1057, 332);
            this.lstView_SearchResult.TabIndex = 1;
            this.lstView_SearchResult.UseCompatibleStateImageBehavior = false;
            this.lstView_SearchResult.View = System.Windows.Forms.View.Details;
            // 
            // btnCounter
            // 
            this.btnCounter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCounter.Location = new System.Drawing.Point(976, 455);
            this.btnCounter.Name = "btnCounter";
            this.btnCounter.Size = new System.Drawing.Size(75, 23);
            this.btnCounter.TabIndex = 2;
            this.btnCounter.Text = "统计";
            this.btnCounter.UseVisualStyleBackColor = true;
            this.btnCounter.Click += new System.EventHandler(this.btnCounter_Click);
            // 
            // radioBtn_CheckAll
            // 
            this.radioBtn_CheckAll.AutoSize = true;
            this.radioBtn_CheckAll.Location = new System.Drawing.Point(0, 3);
            this.radioBtn_CheckAll.Name = "radioBtn_CheckAll";
            this.radioBtn_CheckAll.Size = new System.Drawing.Size(47, 16);
            this.radioBtn_CheckAll.TabIndex = 3;
            this.radioBtn_CheckAll.TabStop = true;
            this.radioBtn_CheckAll.Text = "全选";
            this.radioBtn_CheckAll.UseVisualStyleBackColor = true;
            this.radioBtn_CheckAll.Click += new System.EventHandler(this.radioBtn_CheckAll_Click);
            // 
            // radioBtn_CheckRev
            // 
            this.radioBtn_CheckRev.AutoSize = true;
            this.radioBtn_CheckRev.Location = new System.Drawing.Point(53, 3);
            this.radioBtn_CheckRev.Name = "radioBtn_CheckRev";
            this.radioBtn_CheckRev.Size = new System.Drawing.Size(47, 16);
            this.radioBtn_CheckRev.TabIndex = 4;
            this.radioBtn_CheckRev.TabStop = true;
            this.radioBtn_CheckRev.Text = "反选";
            this.radioBtn_CheckRev.UseVisualStyleBackColor = true;
            this.radioBtn_CheckRev.Click += new System.EventHandler(this.radioBtn_CheckRev_Click);
            // 
            // panel_RadioBtn
            // 
            this.panel_RadioBtn.Controls.Add(this.radioBtn_CheckAll);
            this.panel_RadioBtn.Controls.Add(this.radioBtn_CheckRev);
            this.panel_RadioBtn.Location = new System.Drawing.Point(3, 94);
            this.panel_RadioBtn.Name = "panel_RadioBtn";
            this.panel_RadioBtn.Size = new System.Drawing.Size(200, 17);
            this.panel_RadioBtn.TabIndex = 5;
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 481);
            this.Controls.Add(this.panel_RadioBtn);
            this.Controls.Add(this.btnCounter);
            this.Controls.Add(this.lstView_SearchResult);
            this.Controls.Add(this.grpBox_SearchCondtion);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TFS Code Counter";
            this.grpBox_SearchCondtion.ResumeLayout(false);
            this.panel_RadioBtn.ResumeLayout(false);
            this.panel_RadioBtn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBox_SearchCondtion;
        private System.Windows.Forms.ListView lstView_SearchResult;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCounter;
        private System.Windows.Forms.RadioButton radioBtn_CheckAll;
        private System.Windows.Forms.RadioButton radioBtn_CheckRev;
        private System.Windows.Forms.Panel panel_RadioBtn;
    }
}

