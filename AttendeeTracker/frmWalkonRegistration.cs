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
    public partial class frmWalkonRegistration : Form
    {
        
        public frmWalkonRegistration()
        {
            InitializeComponent();
        }

        public WalkonResult GetWalkonResult() {
            WalkonResult CapturedInput = new WalkonResult();
            CapturedInput.FirstName = txtFirstName.Text;
            CapturedInput.LastName = txtLastName.Text;
            CapturedInput.Company = txtCompany.Text;
            CapturedInput.Email = txtEmail.Text;
            return CapturedInput;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
