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

            TeamProjectPicker picker = new TeamProjectPicker(TeamProjectPickerMode.SingleProject, false);
            if (DialogResult.OK != picker.ShowDialog())
                return;

            TeamProject selectedProject = null;

            TfsTeamProjectCollection projCollection = picker.SelectedTeamProjectCollection;
            VersionControlServer vcs = projCollection.GetService<VersionControlServer>();
            TeamProject[] projects = vcs.GetAllTeamProjects(true);
            foreach (TeamProject project in projects)
            {
                if (project.Name == picker.SelectedProjects[0].Name)
                {
                    selectedProject = project;
                    break;
                }
            }

            if (null != selectedProject)
            {
                Application.Run(new Form1(selectedProject));
            }

        }
    }
}
