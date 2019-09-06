﻿using System;
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
            this.lstView_SearchResult.Columns.Add("用户", 120, HorizontalAlignment.Left);
            this.lstView_SearchResult.Columns.Add("日期", 150, HorizontalAlignment.Left);
            this.lstView_SearchResult.Columns.Add("注释", 600, HorizontalAlignment.Left);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lstView_SearchResult.Items.Clear();
            checkBox_CheckAllNot.Checked = true;

            try
            {
                VersionControlServer vcs = currentPrj.VersionControlServer;
                var changeSets = vcs.QueryHistory(
                      currentPrj.ServerItem, // @"$/AutoThink/DCS_AT"
                      VersionSpec.Latest,
                      0,
                      RecursionType.Full,
                      textBox_Commiter.Text.Trim(),
                      null,
                      null,
                      int.MaxValue,
                      true,
                      false).Cast<Changeset>();

                int nIndex = 1;

                foreach (Changeset changeSet in changeSets)
                {
                    DateTime dtCreationDate = changeSet.CreationDate;

                    if (dtCreationDate.CompareTo(dateTimePicker_To.Value) > 0)
                        continue;

                    if (dtCreationDate.CompareTo(dateTimePicker_From.Value) < 0)
                        break;

                    string commiter = changeSet.Committer;
                    int pos = commiter.LastIndexOf('\\');
                    if (pos > 0)
                        commiter = commiter.Substring(pos + 1, commiter.Length - pos - 1);

                    ListViewItem item = null;
                    item = new ListViewItem();
                    item.SubItems[0].Text = (nIndex++).ToString();
                    item.SubItems.Add(changeSet.ChangesetId.ToString());
                    item.SubItems.Add(commiter);
                    item.SubItems.Add(changeSet.CreationDate.ToString());
                    item.SubItems.Add(changeSet.Comment);
                    this.lstView_SearchResult.Items.Add(item);
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text);
            }
        }

        private void btnCounter_Click(object sender, EventArgs e)
        {
            if (lstView_SearchResult.CheckedItems.Count < 1)
            {
                textBox_Output.Text = "请选择要统计的变更集信息...";
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
            int index = 1;
            foreach (ListViewItem item in items)
            {
                string changsetID = item.SubItems[1].Text;

                string outputInfo = "";
                outputInfo = string.Format("{0}正在获取变更集信息：{1}（{2}/{3}）", ((index == 1) ? "" : "\r\n"), changsetID, index++, items.Count);
                textBox_Output.Text += outputInfo;

                downloadFiles(current, previous, changsetID);
            }

            textBox_Output.Clear();

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

                if (changesetList.Count<Changeset>() != 1)
                {
                    return;
                }

                Changeset changetset = changesetList.First<Changeset>();
                string committer = changetset.Committer;
                int pos = committer.LastIndexOf('\\');
                if (pos > 0)
                    committer = committer.Substring(pos + 1, committer.Length - pos - 1);

                Change[] changes = changetset.Changes;
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
                        string localItem = revisionpath + @"\" + committer + @"\" + changsetID;
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
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text);
            }
        }

        private void diffCount(string current, string previous)
        {
            string[] dirs = Directory.GetDirectories(current);
            if (dirs.Count<string>() < 1)
            {
                return;
            }

            Process proc = new Process();
            proc.StartInfo.CreateNoWindow = true;
            proc.StartInfo.FileName = "cmd.exe";
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.RedirectStandardError = true;
            proc.StartInfo.RedirectStandardInput = true;
            proc.StartInfo.RedirectStandardOutput = true;
            proc.Start();

            foreach (string dir in dirs)
            {
                DirectoryInfo dirInfo = new DirectoryInfo(dir);
                string cmd = string.Format("diffcount.exe \"{0}\\{1}\" \"{2}\\{1}\"", previous, dirInfo.Name, current);
                proc.StandardInput.WriteLine(cmd);
            }

            proc.StandardInput.WriteLine("exit");

            StreamReader reader = proc.StandardOutput;//截取输出流
            string line = reader.ReadLine();//每次读取一行
            while (!reader.EndOfStream)
            {
                if (line.StartsWith("Diffcount"))
                {
                    break;
                }

                line = reader.ReadLine();
            }

            string sOutput = "";

            while (!reader.EndOfStream)
            {
                if (line.IndexOf(">") > 0
                    || line.IndexOf("Convert") > 0
                    || line.IndexOf("Total") > 0)
                {
                    line = reader.ReadLine();
                    continue;
                }

                if (line.StartsWith("Diffcount"))
                {
                    int start = line.LastIndexOf("\\");
                    int end = line.LastIndexOf("]");
                    line = line.Substring(start + 1, end - start - 1);
                }

                sOutput += line;
                sOutput += "\r\n";

                line = reader.ReadLine();
            }

            sOutput = sOutput.Replace("\r\n\r\n\r\n\r\n", "\r\n\r\n");
            textBox_Output.Text = sOutput;

            proc.Close();
        }

        private void checkBox_CheckAll_Click(object sender, EventArgs e)
        {
            checkBox_CheckAllNot.Checked = false;
            foreach (ListViewItem item in lstView_SearchResult.Items)
            {
                item.Checked = true;
            }
        }

        private void checkBox_CheckAllNot_Click(object sender, EventArgs e)
        {
            checkBox_CheckAll.Checked = false;
            foreach (ListViewItem item in lstView_SearchResult.Items)
            {
                item.Checked = false;
            }
        }

        private void MenuItem_About_Click(object sender, EventArgs e)
        {
            string sInfo = "软件说明：\r\n";
            sInfo += "本软件使用第三方工具diffcount进行代码行数统计\r\n\r\n";
            sInfo += "参数说明：\r\n";
            sInfo += "ADD  MOD  DEL  A&M       BLK  CMT  NBNC         RATE\r\n";
            sInfo += "新增 修改 删除 新增+修改 空行 注释 非空非注释行 标准C折算率";
            MessageBox.Show(sInfo, "关于 TFS Code Counter");
        }
    }
}
