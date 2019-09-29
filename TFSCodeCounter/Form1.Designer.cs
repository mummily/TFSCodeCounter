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
            this.textBox_Commiter = new System.Windows.Forms.TextBox();
            this.dateTimePicker_To = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker_From = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lstView_SearchResult = new System.Windows.Forms.ListView();
            this.btnCounter = new System.Windows.Forms.Button();
            this.textBox_Output = new System.Windows.Forms.RichTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox_CheckAll = new System.Windows.Forms.CheckBox();
            this.checkBox_CheckAllNot = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuItem_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_About = new System.Windows.Forms.ToolStripMenuItem();
            this.grpBox_SearchCondtion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBox_SearchCondtion
            // 
            this.grpBox_SearchCondtion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBox_SearchCondtion.Controls.Add(this.label2);
            this.grpBox_SearchCondtion.Controls.Add(this.label1);
            this.grpBox_SearchCondtion.Controls.Add(this.textBox_Commiter);
            this.grpBox_SearchCondtion.Controls.Add(this.dateTimePicker_To);
            this.grpBox_SearchCondtion.Controls.Add(this.label4);
            this.grpBox_SearchCondtion.Controls.Add(this.label3);
            this.grpBox_SearchCondtion.Controls.Add(this.dateTimePicker_From);
            this.grpBox_SearchCondtion.Controls.Add(this.btnSearch);
            this.grpBox_SearchCondtion.Location = new System.Drawing.Point(10, 27);
            this.grpBox_SearchCondtion.Name = "grpBox_SearchCondtion";
            this.grpBox_SearchCondtion.Size = new System.Drawing.Size(1038, 61);
            this.grpBox_SearchCondtion.TabIndex = 0;
            this.grpBox_SearchCondtion.TabStop = false;
            this.grpBox_SearchCondtion.Text = "检索条件";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(358, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "用户";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(496, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "*默认全部用户";
            // 
            // textBox_Commiter
            // 
            this.textBox_Commiter.Location = new System.Drawing.Point(390, 24);
            this.textBox_Commiter.Name = "textBox_Commiter";
            this.textBox_Commiter.Size = new System.Drawing.Size(100, 21);
            this.textBox_Commiter.TabIndex = 9;
            // 
            // dateTimePicker_To
            // 
            this.dateTimePicker_To.Location = new System.Drawing.Point(186, 24);
            this.dateTimePicker_To.Name = "dateTimePicker_To";
            this.dateTimePicker_To.Size = new System.Drawing.Size(104, 21);
            this.dateTimePicker_To.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "～";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "日期从";
            // 
            // dateTimePicker_From
            // 
            this.dateTimePicker_From.Location = new System.Drawing.Point(61, 24);
            this.dateTimePicker_From.Name = "dateTimePicker_From";
            this.dateTimePicker_From.Size = new System.Drawing.Size(104, 21);
            this.dateTimePicker_From.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(943, 23);
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
            this.groupBox1.Controls.Add(this.checkBox_CheckAll);
            this.groupBox1.Controls.Add(this.lstView_SearchResult);
            this.groupBox1.Controls.Add(this.checkBox_CheckAllNot);
            this.groupBox1.Controls.Add(this.btnCounter);
            this.groupBox1.Location = new System.Drawing.Point(10, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1038, 187);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "变更集信息";
            // 
            // checkBox_CheckAll
            // 
            this.checkBox_CheckAll.AutoSize = true;
            this.checkBox_CheckAll.Location = new System.Drawing.Point(17, 26);
            this.checkBox_CheckAll.Name = "checkBox_CheckAll";
            this.checkBox_CheckAll.Size = new System.Drawing.Size(48, 16);
            this.checkBox_CheckAll.TabIndex = 3;
            this.checkBox_CheckAll.Text = "全选";
            this.checkBox_CheckAll.UseVisualStyleBackColor = true;
            this.checkBox_CheckAll.Click += new System.EventHandler(this.checkBox_CheckAll_Click);
            // 
            // checkBox_CheckAllNot
            // 
            this.checkBox_CheckAllNot.AutoSize = true;
            this.checkBox_CheckAllNot.Location = new System.Drawing.Point(72, 26);
            this.checkBox_CheckAllNot.Name = "checkBox_CheckAllNot";
            this.checkBox_CheckAllNot.Size = new System.Drawing.Size(60, 16);
            this.checkBox_CheckAllNot.TabIndex = 4;
            this.checkBox_CheckAllNot.Text = "全不选";
            this.checkBox_CheckAllNot.UseVisualStyleBackColor = true;
            this.checkBox_CheckAllNot.Click += new System.EventHandler(this.checkBox_CheckAllNot_Click);
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
            this.Controls.Add(this.grpBox_SearchCondtion);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TFS Code Counter";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.grpBox_SearchCondtion.ResumeLayout(false);
            this.grpBox_SearchCondtion.PerformLayout();
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

        private System.Windows.Forms.GroupBox grpBox_SearchCondtion;
        private System.Windows.Forms.ListView lstView_SearchResult;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCounter;
        private System.Windows.Forms.RichTextBox textBox_Output;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker_To;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker_From;
        private System.Windows.Forms.TextBox textBox_Commiter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Help;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_About;
        private System.Windows.Forms.CheckBox checkBox_CheckAll;
        private System.Windows.Forms.CheckBox checkBox_CheckAllNot;
    }
}

