using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windowForm2.Global
{
    public partial class Account_SignIn : Form
    {
        public Account_SignIn()
        {
            InitializeComponent();
        }

        public String txtUserName
        {
            get { return txtUsername_signIn.Text.ToString().Trim(); }
        }

        public String txtPassword
        {
            get { return txtPassword_signIn.Text.ToString().Trim(); }
        }

        public String role { get; set; }

        private void radioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnStudent.Checked)
            {
                role = "student";
            }
            if (radioBtnAdmin.Checked)
            {
                role = "admin";
            }
            if (radioBtnEmployer.Checked)
            {
                role = "employer";
            }
        }
    }
}
