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
    public partial class Account_SignUp : Form
    {
        public Account_SignUp()
        {
            InitializeComponent();
        }

        private void Account_SignUp_Load(object sender, EventArgs e)
        {

        }

        private void txtUsername_signIn_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelAccount_Insert_Paint(object sender, PaintEventArgs e)
        {

        }

        public String txtUserName { get { return txtUsername_signUp.Text.ToString().Trim(); } }
        public String txtPassword { get { return txtPassword_signUp.Text.ToString().Trim(); } }
        public String txtRePassword { get { return txtPassword_reEnter.Text.ToString().Trim(); } }
        public String role { get; set; }

        private void radioBtnStudent_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnStudent.Checked)
            {
                role = "student";
            }
            if (radioBtnEmployer.Checked)
            {
                role = "employer";
            }
        }
    }
}
