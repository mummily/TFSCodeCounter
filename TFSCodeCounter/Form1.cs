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
using System.Configuration;

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
            lstViewSearchResult.FullRowSelect = true;

            this.lstViewSearchResult.Columns.Add("序号", 50, HorizontalAlignment.Left);
            this.lstViewSearchResult.Columns.Add("变更集", 60, HorizontalAlignment.Left);
            this.lstViewSearchResult.Columns.Add("用户", 120, HorizontalAlignment.Left);
            this.lstViewSearchResult.Columns.Add("日期", 150, HorizontalAlignment.Left);
            this.lstViewSearchResult.Columns.Add("注释", 600, HorizontalAlignment.Left);
        }

        /// <summary>
        /// 窗口关闭，删除缓存文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            string current = Application.StartupPath + @"\current";
            try
            {
                if (Directory.Exists(current))
                    Directory.Delete(current, true);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(current + "\r\n" + ex.Message, this.Text);
            }

            string previous = Application.StartupPath + @"\previous";
            try
            {
                if (Directory.Exists(previous))
                    Directory.Delete(previous, true);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(previous + "\r\n" + ex.Message, this.Text);
            }

            Configuration config = System.Configuration.ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            // 源位置
            config.AppSettings.Settings.Remove("location.path");
            foreach (object obj in comboBoxLocation.Items)
            {
                config.AppSettings.Settings.Add("location.path", obj.ToString());
            }

            // 用户
            config.AppSettings.Settings.Remove("user.name");
            foreach (object obj in comboBoxUser.Items)
            {
                config.AppSettings.Settings.Add("user.name", obj.ToString());
            }

            // 变更集数
            config.AppSettings.Settings.Remove("changeset.number");
            config.AppSettings.Settings.Add("changeset.number", textBoxChangesetNum.Text);

            // CheckBox是否选中
            config.AppSettings.Settings.Remove("location.checked");
            config.AppSettings.Settings.Add("location.checked", checkBoxLocation.Checked.ToString());
            config.AppSettings.Settings.Remove("user.checked");
            config.AppSettings.Settings.Add("user.checked", checkBoxUser.Checked.ToString());
            config.AppSettings.Settings.Remove("datetime.checked");
            config.AppSettings.Settings.Add("datetime.checked", checkBoxDate.Checked.ToString());
            config.AppSettings.Settings.Remove("changeset.checked");
            config.AppSettings.Settings.Add("changeset.checked", checkBoxChangesetNum.Checked.ToString());

            // 输出区是否显示
            config.AppSettings.Settings.Remove("output.show");
            config.AppSettings.Settings.Add("output.show", (!splitContainer1.Panel2Collapsed).ToString());

            config.Save(ConfigurationSaveMode.Modified);
        }

        /// <summary>
        /// “检索”按钮执行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            // 基于全部用户查询时，才可整体统计
            btnCounterAll.Enabled = (!checkBoxUser.Checked || comboBoxUser.Text.Trim() == "");
            // 清空结果视图
            lstViewSearchResult.Items.Clear();
            checkBoxCheckAllNot.Checked = true;
            if (checkBoxLocation.Checked && comboBoxLocation.Text.Trim() == "")
                comboBoxLocation.SelectedIndex = 0;

            DateTime dtFrom = new DateTime(dateTimePickerFrom.Value.Year, dateTimePickerFrom.Value.Month, dateTimePickerFrom.Value.Day, 0, 0, 0);
            DateTime dtTo = new DateTime(dateTimePickerTo.Value.Year, dateTimePickerTo.Value.Month, dateTimePickerTo.Value.Day, 23, 59, 59);

            try
            {
                int maxCount = checkBoxChangesetNum.Checked ? int.Parse(textBoxChangesetNum.Text) : int.MaxValue;
                string queryUser = checkBoxUser.Checked ? comboBoxUser.Text.Trim() : "";
                string path = checkBoxLocation.Checked ? comboBoxLocation.Text.Trim() : currentPrj.ServerItem;

                VersionControlServer vcs = currentPrj.VersionControlServer;
                var changeSets = vcs.QueryHistory(path,
                      VersionSpec.Latest,
                      0,
                      RecursionType.Full,
                      queryUser,
                      null,
                      null,
                      maxCount,
                      false,
                      false).Cast<Changeset>();

                int nIndex = 1;

                foreach (Changeset changeSet in changeSets)
                {
                    if (checkBoxDate.Checked)
                    {
                        DateTime dtCreationDate = changeSet.CreationDate;

                        if (dtCreationDate.CompareTo(dtTo) > 0)
                            continue;

                        if (dtCreationDate.CompareTo(dtFrom) < 0)
                            break;
                    }

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
                    this.lstViewSearchResult.Items.Add(item);
                }

                if (-1 == comboBoxUser.Items.IndexOf(queryUser) && "" != queryUser.Trim())
                {
                    comboBoxUser.Items.Add(queryUser);
                }

                if (changeSets.Count() > 0 && -1 == comboBoxLocation.Items.IndexOf(path))
                {
                    comboBoxLocation.Items.Add(path);
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text);
            }
        }

        /// <summary>
        /// 整体差异统计
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCounterAll_Click(object sender, EventArgs e)
        {
            if (splitContainer1.Panel2Collapsed)
            {
                btnShowOutput.PerformClick();
            }

            if (lstViewSearchResult.CheckedItems.Count < 1)
            {
                textBoxOutput.Text = "请选择要统计的变更集信息...";
                return;
            }

            textBoxOutput.Clear();

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

            SortedSet<int> itemIndexs = new SortedSet<int>();
            foreach (ListViewItem item in lstViewSearchResult.CheckedItems)
            {
                itemIndexs.Add(item.Index);
            }

            List<String> changesetIds = new List<String>();
            for (int row = itemIndexs.Last(); row >= itemIndexs.First(); --row)
            {
                string changeid = lstViewSearchResult.Items[row].SubItems[1].Text;
                changesetIds.Add(changeid);
            }

            string folder = string.Format("[{0}, {1}]", changesetIds.First(), changesetIds.Last());

            int index = 1;
            foreach (string changsetID in changesetIds)
            {
                string outputInfo = "";
                outputInfo = string.Format("{0}正在获取变更集信息：{1}（{2}/{3}）", ((index == 1) ? "" : "\r\n"), changsetID, index++, changesetIds.Count);
                textBoxOutput.Text += outputInfo;

                downloadFiles(current, previous, folder, changsetID);
            }

            textBoxOutput.Clear();

            diffCount(current, previous);
        }

        /// <summary>
        /// “统计”按钮执行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCounter_Click(object sender, EventArgs e)
        {
            if (splitContainer1.Panel2Collapsed)
            {
                btnShowOutput.PerformClick();
            }

            if (lstViewSearchResult.CheckedItems.Count < 1)
            {
                textBoxOutput.Text = "请选择要统计的变更集信息...";
                return;
            }

            textBoxOutput.Clear();

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

            var items = lstViewSearchResult.CheckedItems;
            int index = 1;
            foreach (ListViewItem item in items)
            {
                string changsetID = item.SubItems[1].Text;

                string outputInfo = "";
                outputInfo = string.Format("{0}正在获取变更集信息：{1}（{2}/{3}）", ((index == 1) ? "" : "\r\n"), changsetID, index++, items.Count);
                textBoxOutput.Text += outputInfo;

                downloadFiles(current, previous, changsetID);
            }

            textBoxOutput.Clear();

            diffCount(current, previous);
        }

        /// <summary>
        /// 下载文件
        /// </summary>
        /// <param name="current"></param>
        /// <param name="previous"></param>
        /// <param name="changsetID"></param>
        private void downloadFiles(string current, string previous, string changsetID)
        {
            try
            {
                VersionControlServer vcs = currentPrj.VersionControlServer;

                var changesetList = vcs.QueryHistory(currentPrj.ServerItem,
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
                    FileInfo fi = new FileInfo(ServerItem);
                    if (fi.Extension.Length < 1) // 不是文件，而是文件夹，不比较
                        continue;

                    var itemChgs = vcs.QueryHistory(change.Item.ServerItem,
                        VersionSpec.Latest,
                        0,
                        RecursionType.Full,
                        null,
                        null,
                        VersionSpec.ParseSingleSpec(changsetID, null),
                        2,
                        true,
                        false).Cast<Changeset>();

                    string currentpath = current + @"\" + committer + @"\" + changsetID + ServerItem.Substring(1);
                    Changeset itemchg = itemChgs.First<Changeset>();

                    if (!itemchg.Changes[0].ChangeType.HasFlag(ChangeType.Delete))
                        vcs.DownloadFile(ServerItem, 0, VersionSpec.ParseSingleSpec(Convert.ToString(itemchg.ChangesetId), null), currentpath);

                    if (itemChgs.Count<Changeset>() > 1)
                    {
                        string previouspath = previous + @"\" + committer + @"\" + changsetID + ServerItem.Substring(1);
                        itemchg = itemChgs.Last<Changeset>();

                        if (!itemchg.Changes[0].ChangeType.HasFlag(ChangeType.Delete))
                            vcs.DownloadFile(ServerItem, 0, VersionSpec.ParseSingleSpec(Convert.ToString(itemchg.ChangesetId), null), previouspath);
                    }
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text);
            }
        }

        /// <summary>
        /// 下载文件
        /// </summary>
        /// <param name="current"></param>
        /// <param name="previous"></param>
        /// <param name="changsetID"></param>
        private void downloadFiles(string current, string previous, string folder, string changsetID)
        {
            try
            {
                VersionControlServer vcs = currentPrj.VersionControlServer;
                var changesetList = vcs.QueryHistory(currentPrj.ServerItem,
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
                Change[] changes = changetset.Changes;
                foreach (Change change in changes)
                {
                    if (change.Item == null)
                        continue;

                    string ServerItem = change.Item.ServerItem;
                    FileInfo fi = new FileInfo(ServerItem);
                    if (fi.Extension.Length < 1) // 不是文件，而是文件夹，不比较
                        continue;

                    var itemChgs = vcs.QueryHistory(change.Item.ServerItem,
                        VersionSpec.Latest,
                        0,
                        RecursionType.Full,
                        null,
                        null,
                        VersionSpec.ParseSingleSpec(changsetID, null),
                        2,
                        true,
                        false).Cast<Changeset>();

                    string currentpath = current + @"\" + folder + ServerItem.Substring(1);
                    Changeset itemchg = itemChgs.First<Changeset>();

                    if (!itemchg.Changes[0].ChangeType.HasFlag(ChangeType.Delete))
                        vcs.DownloadFile(ServerItem, 0, VersionSpec.ParseSingleSpec(Convert.ToString(itemchg.ChangesetId), null), currentpath);

                    if (itemChgs.Count<Changeset>() > 1) // 若新增，则无前一项
                    {
                        string previouspath = previous + @"\" + folder + ServerItem.Substring(1);
                        if (!File.Exists(previouspath))
                        {
                            itemchg = itemChgs.Last<Changeset>();
                            if (!itemchg.Changes[0].ChangeType.HasFlag(ChangeType.Delete))
                                vcs.DownloadFile(ServerItem, 0, VersionSpec.ParseSingleSpec(Convert.ToString(itemchg.ChangesetId), null), previouspath);
                        }
                    }
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text);
            }
        }

        /// <summary>
        /// 比较文件差异
        /// </summary>
        /// <param name="current"></param>
        /// <param name="previous"></param>
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
                string cmd = string.Format("\"{0}\\diffcount.exe\" \"{1}\\{2}\" \"{3}\\{2}\"", Application.StartupPath, previous, dirInfo.Name, current);
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
            textBoxOutput.Text = sOutput;

            proc.Close();
        }

        /// <summary>
        /// 全选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox_CheckAll_Click(object sender, EventArgs e)
        {
            checkBoxCheckAllNot.Checked = false;
            foreach (ListViewItem item in lstViewSearchResult.Items)
            {
                item.Checked = true;
            }
        }

        /// <summary>
        /// 全不选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox_CheckAllNot_Click(object sender, EventArgs e)
        {
            checkBoxCheckAll.Checked = false;
            foreach (ListViewItem item in lstViewSearchResult.Items)
            {
                item.Checked = false;
            }
        }

        /// <summary>
        /// 关于
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItem_About_Click(object sender, EventArgs e)
        {
            string sInfo = "软件说明：\r\n";
            sInfo += "本软件使用第三方工具diffcount进行代码行数统计\r\n\r\n";
            sInfo += "参数说明：\r\n";
            sInfo += "ADD  MOD  DEL  A&M       BLK  CMT  NBNC         RATE\r\n";
            sInfo += "新增 修改 删除 新增+修改 空行 注释 非空非注释行 标准C折算率";
            MessageBox.Show(sInfo, "关于 TFS Code Counter");
        }

        /// <summary>
        /// 显示输出区按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShowOutput_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2Collapsed = !splitContainer1.Panel2Collapsed;
            btnShowOutput.Text = splitContainer1.Panel2Collapsed ? "︽" : "︾";
        }

        /// <summary>
        /// 变更集数量输入验证
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxChangesetNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 默认不让输入
            e.Handled = true;

            // 退格符、数字可输入
            if ('\b' == e.KeyChar || char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }

            // 0 不能作为起始输入
            if (textBoxChangesetNum.SelectionStart == 0 && e.KeyChar == '0')
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// 变更集数量选择态改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxChangesetNum_CheckedChanged(object sender, EventArgs e)
        {
            textBoxChangesetNum.Enabled = checkBoxChangesetNum.Checked;
        }

        /// <summary>
        /// 日期选择态改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxDate_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerFrom.Enabled = checkBoxDate.Checked;
            dateTimePickerTo.Enabled = checkBoxDate.Checked;
        }

        /// <summary>
        /// 用户选择态改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxUser_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxUser.Enabled = checkBoxUser.Checked;
        }

        /// <summary>
        /// 源位置改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxLocation_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxLocation.Enabled = checkBoxLocation.Checked;
        }

        /// <summary>
        /// 初始化应用设置
        /// </summary>
        private void InitSetting()
        {
            Configuration config = System.Configuration.ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            // 源位置
            string sLocation = config.AppSettings.Settings["location.path"].Value;
            if (sLocation.Trim() == "")
            {
                comboBoxLocation.Items.Add(currentPrj.ServerItem);
            }
            else
            {
                string[] sPaths = sLocation.Split(',');
                foreach (string sPath in sPaths)
                {
                    if (-1 == comboBoxLocation.Items.IndexOf(sPath) && "" != sPath.Trim())
                    {
                        comboBoxLocation.Items.Add(sPath);
                    }
                }
            }
            if (comboBoxLocation.Items.Count > 0)
                comboBoxLocation.SelectedIndex = 0;

            // 查询用户 user.name
            string sUserName = config.AppSettings.Settings["user.name"].Value;
            if (sUserName.Trim() == "")
            {
                string sUser = currentPrj.VersionControlServer.AuthorizedUser;
                int pos = sUser.LastIndexOf('\\');
                if (pos > 0)
                    sUser = sUser.Substring(pos + 1, sUser.Length - pos - 1);

                comboBoxUser.Items.Add(sUser); // 当前用户
            }
            else
            {
                string[] sNames = sUserName.Split(',');
                foreach (string sName in sNames)
                {
                    if (-1 == comboBoxUser.Items.IndexOf(sName) && "" != sName.Trim())
                    {
                        comboBoxUser.Items.Add(sName);
                    }
                }
            }

            // 用户默认第一个
            if (comboBoxUser.Items.Count > 0)
                comboBoxUser.SelectedIndex = 0;

            // 变更集数 changeset.number 默认最新10条
            textBoxChangesetNum.Text = "10";
            int nChangesetNum = 10;
            if (int.TryParse(config.AppSettings.Settings["changeset.number"].Value.ToString(), out nChangesetNum))
                textBoxChangesetNum.Text = config.AppSettings.Settings["changeset.number"].Value.ToString();

            // 查询日期 datetime.checked
            bool bChecked = true;
            Boolean.TryParse(config.AppSettings.Settings["datetime.checked"].Value.ToString(), out bChecked);
            checkBoxDate.Checked = bChecked;
            // 查询用户 user.checked
            bChecked = true;
            Boolean.TryParse(config.AppSettings.Settings["user.checked"].Value.ToString(), out bChecked);
            checkBoxUser.Checked = bChecked;
            // 查询源位置 location.checked
            bChecked = true;
            Boolean.TryParse(config.AppSettings.Settings["location.checked"].Value.ToString(), out bChecked);
            checkBoxLocation.Checked = bChecked;
            // 查询变更集数 changeset.checked
            bChecked = true;
            Boolean.TryParse(config.AppSettings.Settings["changeset.checked"].Value.ToString(), out bChecked);
            checkBoxChangesetNum.Checked = bChecked;

            // 是否显示输出区
            bool bShow = false;
            Boolean.TryParse(config.AppSettings.Settings["output.show"].Value.ToString(), out bShow);
            if (!bShow)
                btnShowOutput_Click(null, EventArgs.Empty);
        }

        /// <summary>
        /// 加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Load(object sender, EventArgs e)
        {
            // 整体变更统计
            btnCounterAll.Enabled = false;
            // 日期
            DateTime dtFrom = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1, 0, 0, 0);
            dateTimePickerFrom.Text = dtFrom.ToString();
            dateTimePickerTo.Text = DateTime.Now.ToString();

            // 初始化设置
            InitSetting();
        }
    }
}