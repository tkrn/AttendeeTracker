using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AttendeeTracker
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        private void frmAbout_Load(object sender, EventArgs e)
        {
            Version version = new Version(Application.ProductVersion);
            lblVersion.Text = String.Format("Version {0}.{1}", version.Major, version.Minor);
            lblBuiltOn.Text = String.Format("Built on {0}", Properties.Resources.BuildDate);   
        }

        private void lnkGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.github.com/tkrn/AttendeeTracker");  
        }

    }
}
