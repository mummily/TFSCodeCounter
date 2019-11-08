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
            this.grpBoxSearchCondtion = new System.Windows.Forms.GroupBox();
            this.textBoxChangesetNum = new System.Windows.Forms.TextBox();
            this.checkBoxChangesetNum = new System.Windows.Forms.CheckBox();
            this.checkBoxDate = new System.Windows.Forms.CheckBox();
            this.checkBoxUser = new System.Windows.Forms.CheckBox();
            this.comboBoxUser = new System.Windows.Forms.ComboBox();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lstViewSearchResult = new System.Windows.Forms.ListView();
            this.btnCounter = new System.Windows.Forms.Button();
            this.textBoxOutput = new System.Windows.Forms.RichTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnShowOutput = new System.Windows.Forms.Button();
            this.checkBoxCheckAll = new System.Windows.Forms.CheckBox();
            this.checkBoxCheckAllNot = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuItem_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_About = new System.Windows.Forms.ToolStripMenuItem();
            this.grpBoxSearchCondtion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxSearchCondtion
            // 
            this.grpBoxSearchCondtion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBoxSearchCondtion.Controls.Add(this.textBoxChangesetNum);
            this.grpBoxSearchCondtion.Controls.Add(this.checkBoxChangesetNum);
            this.grpBoxSearchCondtion.Controls.Add(this.checkBoxDate);
            this.grpBoxSearchCondtion.Controls.Add(this.checkBoxUser);
            this.grpBoxSearchCondtion.Controls.Add(this.comboBoxUser);
            this.grpBoxSearchCondtion.Controls.Add(this.dateTimePickerTo);
            this.grpBoxSearchCondtion.Controls.Add(this.label4);
            this.grpBoxSearchCondtion.Controls.Add(this.dateTimePickerFrom);
            this.grpBoxSearchCondtion.Controls.Add(this.btnSearch);
            this.grpBoxSearchCondtion.Location = new System.Drawing.Point(10, 27);
            this.grpBoxSearchCondtion.Name = "grpBoxSearchCondtion";
            this.grpBoxSearchCondtion.Size = new System.Drawing.Size(1038, 61);
            this.grpBoxSearchCondtion.TabIndex = 0;
            this.grpBoxSearchCondtion.TabStop = false;
            this.grpBoxSearchCondtion.Text = "检索条件";
            // 
            // textBoxChangesetNum
            // 
            this.textBoxChangesetNum.Location = new System.Drawing.Point(685, 26);
            this.textBoxChangesetNum.Name = "textBoxChangesetNum";
            this.textBoxChangesetNum.Size = new System.Drawing.Size(65, 21);
            this.textBoxChangesetNum.TabIndex = 14;
            this.textBoxChangesetNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxChangesetNum_KeyPress);
            // 
            // checkBoxChangesetNum
            // 
            this.checkBoxChangesetNum.AutoSize = true;
            this.checkBoxChangesetNum.Checked = true;
            this.checkBoxChangesetNum.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxChangesetNum.Location = new System.Drawing.Point(609, 28);
            this.checkBoxChangesetNum.Name = "checkBoxChangesetNum";
            this.checkBoxChangesetNum.Size = new System.Drawing.Size(78, 16);
            this.checkBoxChangesetNum.TabIndex = 13;
            this.checkBoxChangesetNum.Text = "变更集数:";
            this.checkBoxChangesetNum.UseVisualStyleBackColor = true;
            this.checkBoxChangesetNum.CheckedChanged += new System.EventHandler(this.checkBoxChangesetNum_CheckedChanged);
            // 
            // checkBoxDate
            // 
            this.checkBoxDate.AutoSize = true;
            this.checkBoxDate.Checked = true;
            this.checkBoxDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDate.Location = new System.Drawing.Point(17, 28);
            this.checkBoxDate.Name = "checkBoxDate";
            this.checkBoxDate.Size = new System.Drawing.Size(66, 16);
            this.checkBoxDate.TabIndex = 12;
            this.checkBoxDate.Text = "日期从:";
            this.checkBoxDate.UseVisualStyleBackColor = true;
            this.checkBoxDate.CheckedChanged += new System.EventHandler(this.checkBoxDate_CheckedChanged);
            // 
            // checkBoxUser
            // 
            this.checkBoxUser.AutoSize = true;
            this.checkBoxUser.Checked = true;
            this.checkBoxUser.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxUser.Location = new System.Drawing.Point(382, 28);
            this.checkBoxUser.Name = "checkBoxUser";
            this.checkBoxUser.Size = new System.Drawing.Size(54, 16);
            this.checkBoxUser.TabIndex = 11;
            this.checkBoxUser.Text = "用户:";
            this.checkBoxUser.CheckedChanged += new System.EventHandler(this.checkBoxUser_CheckedChanged);
            // 
            // comboBoxUser
            // 
            this.comboBoxUser.Location = new System.Drawing.Point(436, 26);
            this.comboBoxUser.Name = "comboBoxUser";
            this.comboBoxUser.Size = new System.Drawing.Size(111, 20);
            this.comboBoxUser.TabIndex = 9;
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Location = new System.Drawing.Point(210, 26);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(111, 21);
            this.dateTimePickerTo.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(195, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "～";
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Location = new System.Drawing.Point(83, 26);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(111, 21);
            this.dateTimePickerFrom.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(943, 25);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "检索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lstViewSearchResult
            // 
            this.lstViewSearchResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstViewSearchResult.CheckBoxes = true;
            this.lstViewSearchResult.Location = new System.Drawing.Point(10, 48);
            this.lstViewSearchResult.Name = "lstViewSearchResult";
            this.lstViewSearchResult.Size = new System.Drawing.Size(1022, 104);
            this.lstViewSearchResult.TabIndex = 1;
            this.lstViewSearchResult.UseCompatibleStateImageBehavior = false;
            this.lstViewSearchResult.View = System.Windows.Forms.View.Details;
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
            // textBoxOutput
            // 
            this.textBoxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxOutput.Location = new System.Drawing.Point(10, 20);
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ReadOnly = true;
            this.textBoxOutput.Size = new System.Drawing.Size(1022, 158);
            this.textBoxOutput.TabIndex = 6;
            this.textBoxOutput.Text = "";
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
            this.groupBox1.Controls.Add(this.btnShowOutput);
            this.groupBox1.Controls.Add(this.checkBoxCheckAll);
            this.groupBox1.Controls.Add(this.lstViewSearchResult);
            this.groupBox1.Controls.Add(this.checkBoxCheckAllNot);
            this.groupBox1.Controls.Add(this.btnCounter);
            this.groupBox1.Location = new System.Drawing.Point(10, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1038, 187);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "变更集信息";
            // 
            // btnShowOutput
            // 
            this.btnShowOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnShowOutput.Location = new System.Drawing.Point(10, 158);
            this.btnShowOutput.Name = "btnShowOutput";
            this.btnShowOutput.Size = new System.Drawing.Size(25, 23);
            this.btnShowOutput.TabIndex = 5;
            this.btnShowOutput.Text = "︾";
            this.btnShowOutput.UseVisualStyleBackColor = true;
            this.btnShowOutput.Click += new System.EventHandler(this.btnShowOutput_Click);
            // 
            // checkBoxCheckAll
            // 
            this.checkBoxCheckAll.AutoSize = true;
            this.checkBoxCheckAll.Location = new System.Drawing.Point(17, 26);
            this.checkBoxCheckAll.Name = "checkBoxCheckAll";
            this.checkBoxCheckAll.Size = new System.Drawing.Size(48, 16);
            this.checkBoxCheckAll.TabIndex = 3;
            this.checkBoxCheckAll.Text = "全选";
            this.checkBoxCheckAll.UseVisualStyleBackColor = true;
            this.checkBoxCheckAll.Click += new System.EventHandler(this.checkBox_CheckAll_Click);
            // 
            // checkBoxCheckAllNot
            // 
            this.checkBoxCheckAllNot.AutoSize = true;
            this.checkBoxCheckAllNot.Location = new System.Drawing.Point(72, 26);
            this.checkBoxCheckAllNot.Name = "checkBoxCheckAllNot";
            this.checkBoxCheckAllNot.Size = new System.Drawing.Size(60, 16);
            this.checkBoxCheckAllNot.TabIndex = 4;
            this.checkBoxCheckAllNot.Text = "全不选";
            this.checkBoxCheckAllNot.UseVisualStyleBackColor = true;
            this.checkBoxCheckAllNot.Click += new System.EventHandler(this.checkBox_CheckAllNot_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.textBoxOutput);
            this.groupBox2.Location = new System.Drawing.Point(10, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1038, 183);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "输出信息";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_Help});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1057, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuItem_Help
            // 
            this.MenuItem_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_About});
            this.MenuItem_Help.Name = "MenuItem_Help";
            this.MenuItem_Help.Size = new System.Drawing.Size(59, 20);
            this.MenuItem_Help.Text = "帮助(&H)";
            // 
            // MenuItem_About
            // 
            this.MenuItem_About.Name = "MenuItem_About";
            this.MenuItem_About.Size = new System.Drawing.Size(214, 22);
            this.MenuItem_About.Text = "关于 TFS Code Counter(&A)";
            this.MenuItem_About.Click += new System.EventHandler(this.MenuItem_About_Click);
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 481);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.grpBoxSearchCondtion);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TFS Code Counter";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.grpBoxSearchCondtion.ResumeLayout(false);
            this.grpBoxSearchCondtion.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxSearchCondtion;
        private System.Windows.Forms.ListView lstViewSearchResult;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCounter;
        private System.Windows.Forms.RichTextBox textBoxOutput;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.ComboBox comboBoxUser;
        private System.Windows.Forms.CheckBox checkBoxUser;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Help;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_About;
        private System.Windows.Forms.CheckBox checkBoxCheckAll;
        private System.Windows.Forms.CheckBox checkBoxCheckAllNot;
        private System.Windows.Forms.Button btnShowOutput;
        private System.Windows.Forms.CheckBox checkBoxDate;
        private System.Windows.Forms.CheckBox checkBoxChangesetNum;
        private System.Windows.Forms.TextBox textBoxChangesetNum;
    }
}

