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
        public Form1(VersionControlServer vcs)
        {
            InitializeComponent();

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
        }
    }
}
