using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

using Microsoft.TeamFoundation.VersionControl.Client;


namespace TFSCodeCounter
{
    public partial class frmMain : Form
    {
        TeamProject currentPrj = null;

        public frmMain(TeamProject teamPrj)
        {
            currentPrj = teamPrj;

            InitializeComponent();
            InitControl();
        }


        /// <summary>
        /// 初始化界面控件
        /// </summary>
        private void InitControl()
        {
            DateTime dtFrom = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1, 0, 0, 0);
            dateTimePicker_From.Text = dtFrom.ToString();
            dateTimePicker_To.Text = DateTime.Now.ToString();

            //单选时,选择整行
            this.lstView_SearchResult.FullRowSelect = true;

            this.lstView_SearchResult.Columns.Add("序号", 50, HorizontalAlignment.Left);
            this.lstView_SearchResult.Columns.Add("变更集", 60, HorizontalAlignment.Left);
            this.lstView_SearchResult.Columns.Add("用户", 150, HorizontalAlignment.Left);
            this.lstView_SearchResult.Columns.Add("日期", 120, HorizontalAlignment.Left);
            this.lstView_SearchResult.Columns.Add("注释", 600, HorizontalAlignment.Left);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lstView_SearchResult.Items.Clear();

            VersionControlServer vcs = currentPrj.VersionControlServer;
            var changeSets = vcs.QueryHistory(
                  currentPrj.ServerItem, // @"$/AutoThink/DCS_AT"
                  VersionSpec.Latest,
                  0,
                  RecursionType.Full,
                  checkBox_currentUser.Checked ? vcs.AuthorizedUser : null,
                  null,
                  null,
                  System.Decimal.ToInt32(numericUpDown_Changeset.Value),
                  true,
                  false).Cast<Changeset>();

            int nIndex = 1;
            foreach (Changeset changeSet in changeSets)
            {
                ListViewItem item = null;
                item = new ListViewItem();
                item.SubItems[0].Text = (nIndex++).ToString();
                item.SubItems.Add(changeSet.ChangesetId.ToString());
                item.SubItems.Add(changeSet.Committer);
                item.SubItems.Add(changeSet.CreationDate.ToString());
                item.SubItems.Add(changeSet.Comment);
                this.lstView_SearchResult.Items.Add(item);
            }
        }

        private void btnCounter_Click(object sender, EventArgs e)
        {
            if (lstView_SearchResult.CheckedItems.Count < 1)
            {
                return;
            }

            textBox_Output.Clear();

            string current = Application.StartupPath + @"\current";
            if (Directory.Exists(current))
                Directory.Delete(current, true);
            Directory.CreateDirectory(current);
            File.SetAttributes(current, FileAttributes.Hidden);

            string previous = Application.StartupPath + @"\previous";
            if (Directory.Exists(previous))
                Directory.Delete(previous, true);
            Directory.CreateDirectory(previous);
            File.SetAttributes(previous, FileAttributes.Hidden);

            var items = lstView_SearchResult.CheckedItems;
            foreach (ListViewItem item in items)
            {
                downloadFiles(current, previous, item.SubItems[1].Text);
            }

            diffCount(current, previous);
        }

        private void downloadFiles(string current, string previous, string changsetID)
        {
            try
            {
                VersionControlServer vcs = currentPrj.VersionControlServer;
                
                var changesetList = vcs.QueryHistory(
                  currentPrj.ServerItem,
                  VersionSpec.Latest,
                  0,
                  RecursionType.Full,
                  null,
                  null,
                  VersionSpec.ParseSingleSpec(changsetID, null),
                  1,
                  true,
                  false).Cast<Changeset>();

                foreach (var cs in changesetList)
                {
                    Change[] changes = cs.Changes;
                    foreach (Change change in changes)
                    {
                        if (change.Item == null)
                            continue;

                        string ServerItem = change.Item.ServerItem;

                        var itemChgs = vcs.QueryHistory(change.Item.ServerItem,
                            VersionSpec.Latest,
                            0,
                            RecursionType.Full,
                            null,
                            null,
                            VersionSpec.ParseSingleSpec(changsetID, null),
                            2,
                            true,
                            false);

                        int index = 0;
                        foreach (Changeset itemchg in itemChgs)
                        {
                            string revisionpath = (index == 0) ? current : previous;
                            string localItem = revisionpath + @"\" + changsetID;
                            localItem += ServerItem.Substring(1);
                            //public enum ChangeType
                            //{
                            //    None = 1,
                            //    Add = 2,
                            //    Edit = 4,
                            //    Encoding = 8,
                            //    Rename = 16,
                            //    Delete = 32,
                            //    Undelete = 64,
                            //    Branch = 128,
                            //    Merge = 256,
                            //    Lock = 512,
                            //    Rollback = 1024,
                            //    SourceRename = 2048,
                            //    Property = 8192
                            //}

                            if (!itemchg.Changes[0].ChangeType.HasFlag(ChangeType.Delete))
                                vcs.DownloadFile(ServerItem, 0, VersionSpec.ParseSingleSpec(Convert.ToString(itemchg.ChangesetId), null), localItem);

                            ++index;
                        }
                    }
                }
            }
            catch (ChangesetNotFoundException)
            {
                Console.WriteLine("!! Please check the change set id inside your config file !!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        private void diffCount(string current, string previous)
        {
            string cmd = "diffcount.exe ";
            cmd += previous + " " + current;

            Process proc = new Process();
            proc.StartInfo.CreateNoWindow = true;
            proc.StartInfo.FileName = "cmd.exe";
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.RedirectStandardError = true;
            proc.StartInfo.RedirectStandardInput = true;
            proc.StartInfo.RedirectStandardOutput = true;
            proc.Start();
            proc.StandardInput.WriteLine(cmd);
            proc.StandardInput.WriteLine("exit");

            StreamReader reader = proc.StandardOutput;//截取输出流
            string line = reader.ReadLine();//每次读取一行
            while (!reader.EndOfStream)
            {
                line = reader.ReadLine();
                textBox_Output.Text += line;
                textBox_Output.Text += "\r\n";
            }

            proc.Close();
        }

        private void radioBtn_CheckAll_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lstView_SearchResult.Items)
            {
                item.Checked = true;
            }
        }

        private void radioBtn_CheckRev_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lstView_SearchResult.Items)
            {
                item.Checked = !item.Checked;
            }
        }
    }
}
