using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Microsoft.TeamFoundation.VersionControl.Client;

namespace TFSCodeCounter
{
    public partial class Form1 : Form
    {
        public Form1(TeamProject teamPrj)
        {
            InitializeComponent();

            VersionControlServer vcs = teamPrj.VersionControlServer;
            var changeSets = vcs.QueryHistory(
                  teamPrj.ServerItem, // @"$/AutoThink/DCS_AT"
                  VersionSpec.Latest,
                  0,
                  RecursionType.Full,
                  vcs.AuthorizedUser,
                  null,
                  null,
                  10,
                  true,
                  false).Cast<Changeset>();

            foreach (Changeset changeSet in changeSets)
            {
                Console.WriteLine(changeSet.Comment);
                continue;

                Change[] changes = changeSet.Changes;
                foreach (Change change in changes)
                {
                    if (change.Item == null)
                        continue;
                }
            }
        }
    }
}
