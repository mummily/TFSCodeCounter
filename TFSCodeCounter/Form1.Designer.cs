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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_Changeset = new System.Windows.Forms.NumericUpDown();
            this.checkBox_currentUser = new System.Windows.Forms.CheckBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lstView_SearchResult = new System.Windows.Forms.ListView();
            this.btnCounter = new System.Windows.Forms.Button();
            this.radioBtn_CheckAll = new System.Windows.Forms.RadioButton();
            this.radioBtn_CheckRev = new System.Windows.Forms.RadioButton();
            this.panel_RadioBtn = new System.Windows.Forms.Panel();
            this.textBox_Output = new System.Windows.Forms.RichTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker_From = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker_To = new System.Windows.Forms.DateTimePicker();
            this.grpBox_SearchCondtion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Changeset)).BeginInit();
            this.panel_RadioBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBox_SearchCondtion
            // 
            this.grpBox_SearchCondtion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBox_SearchCondtion.Controls.Add(this.dateTimePicker_To);
            this.grpBox_SearchCondtion.Controls.Add(this.label4);
            this.grpBox_SearchCondtion.Controls.Add(this.label3);
            this.grpBox_SearchCondtion.Controls.Add(this.dateTimePicker_From);
            this.grpBox_SearchCondtion.Controls.Add(this.label2);
            this.grpBox_SearchCondtion.Controls.Add(this.label1);
            this.grpBox_SearchCondtion.Controls.Add(this.numericUpDown_Changeset);
            this.grpBox_SearchCondtion.Controls.Add(this.checkBox_currentUser);
            this.grpBox_SearchCondtion.Controls.Add(this.btnSearch);
            this.grpBox_SearchCondtion.Location = new System.Drawing.Point(10, 4);
            this.grpBox_SearchCondtion.Name = "grpBox_SearchCondtion";
            this.grpBox_SearchCondtion.Size = new System.Drawing.Size(1038, 84);
            this.grpBox_SearchCondtion.TabIndex = 0;
            this.grpBox_SearchCondtion.TabStop = false;
            this.grpBox_SearchCondtion.Text = "检索条件";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "条变更集";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "最近";
            // 
            // numericUpDown_Changeset
            // 
            this.numericUpDown_Changeset.Location = new System.Drawing.Point(43, 34);
            this.numericUpDown_Changeset.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown_Changeset.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_Changeset.Name = "numericUpDown_Changeset";
            this.numericUpDown_Changeset.Size = new System.Drawing.Size(53, 21);
            this.numericUpDown_Changeset.TabIndex = 2;
            this.numericUpDown_Changeset.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // checkBox_currentUser
            // 
            this.checkBox_currentUser.AutoSize = true;
            this.checkBox_currentUser.Checked = true;
            this.checkBox_currentUser.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_currentUser.Location = new System.Drawing.Point(211, 37);
            this.checkBox_currentUser.Name = "checkBox_currentUser";
            this.checkBox_currentUser.Size = new System.Drawing.Size(72, 16);
            this.checkBox_currentUser.TabIndex = 1;
            this.checkBox_currentUser.Text = "当前用户";
            this.checkBox_currentUser.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(943, 55);
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
            this.lstView_SearchResult.Location = new System.Drawing.Point(10, 48);
            this.lstView_SearchResult.Name = "lstView_SearchResult";
            this.lstView_SearchResult.Size = new System.Drawing.Size(1022, 104);
            this.lstView_SearchResult.TabIndex = 1;
            this.lstView_SearchResult.UseCompatibleStateImageBehavior = false;
            this.lstView_SearchResult.View = System.Windows.Forms.View.Details;
            // 
            // btnCounter
            // 
            this.btnCounter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCounter.Location = new System.Drawing.Point(943, 158);
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
            this.radioBtn_CheckAll.Location = new System.Drawing.Point(16, 3);
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
            this.radioBtn_CheckRev.Location = new System.Drawing.Point(69, 3);
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
            this.panel_RadioBtn.Location = new System.Drawing.Point(10, 20);
            this.panel_RadioBtn.Name = "panel_RadioBtn";
            this.panel_RadioBtn.Size = new System.Drawing.Size(193, 22);
            this.panel_RadioBtn.TabIndex = 5;
            // 
            // textBox_Output
            // 
            this.textBox_Output.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Output.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Output.Location = new System.Drawing.Point(10, 20);
            this.textBox_Output.Name = "textBox_Output";
            this.textBox_Output.ReadOnly = true;
            this.textBox_Output.Size = new System.Drawing.Size(1022, 158);
            this.textBox_Output.TabIndex = 6;
            this.textBox_Output.Text = "";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 94);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(1057, 386);
            this.splitContainer1.SplitterDistance = 193;
            this.splitContainer1.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lstView_SearchResult);
            this.groupBox1.Controls.Add(this.btnCounter);
            this.groupBox1.Controls.Add(this.panel_RadioBtn);
            this.groupBox1.Location = new System.Drawing.Point(10, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1038, 187);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "变更集信息";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.textBox_Output);
            this.groupBox2.Location = new System.Drawing.Point(10, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1038, 183);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "输出信息";
            // 
            // dateTimePicker_From
            // 
            this.dateTimePicker_From.Location = new System.Drawing.Point(381, 31);
            this.dateTimePicker_From.Name = "dateTimePicker_From";
            this.dateTimePicker_From.Size = new System.Drawing.Size(104, 21);
            this.dateTimePicker_From.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(337, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "日期从";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(488, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "～";
            // 
            // dateTimePicker_To
            // 
            this.dateTimePicker_To.Location = new System.Drawing.Point(506, 31);
            this.dateTimePicker_To.Name = "dateTimePicker_To";
            this.dateTimePicker_To.Size = new System.Drawing.Size(104, 21);
            this.dateTimePicker_To.TabIndex = 8;
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 481);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.grpBox_SearchCondtion);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TFS Code Counter";
            this.grpBox_SearchCondtion.ResumeLayout(false);
            this.grpBox_SearchCondtion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Changeset)).EndInit();
            this.panel_RadioBtn.ResumeLayout(false);
            this.panel_RadioBtn.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
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
        private System.Windows.Forms.CheckBox checkBox_currentUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown_Changeset;
        private System.Windows.Forms.RichTextBox textBox_Output;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker_To;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker_From;
    }
}

