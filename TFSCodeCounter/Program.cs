using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using Microsoft.TeamFoundation.Client;
using Microsoft.TeamFoundation.Server;
using Microsoft.TeamFoundation.VersionControl;
using Microsoft.TeamFoundation.VersionControl.Client;

namespace TFSCodeCounter
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            TeamProjectPicker tpp = new TeamProjectPicker(TeamProjectPickerMode.SingleProject, false);
            if (DialogResult.OK != tpp.ShowDialog())
                return;

            TfsTeamProjectCollection projCollection = tpp.SelectedTeamProjectCollection;
            VersionControlServer vcs = projCollection.GetService<VersionControlServer>();

            var changesetList = vcs.QueryHistory(
                  @"$/AutoThink/DCS_AT/02_Code",
                  VersionSpec.Latest,
                  0,
                  RecursionType.Full,
                  vcs.AuthorizedUser,
                  null,
                  null,
                  10,
                  true,
                  false).Cast<Changeset>();

            Application.Run(new Form1(changesetList));
        }
    }
}
