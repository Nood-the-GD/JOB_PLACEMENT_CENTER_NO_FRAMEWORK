using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using windowForm2.Global;
using windowForm2.Notification;
using windowForm2.FactoryMethod;

namespace windowForm2
{
    public partial class Account_Insert : Form
    {
        bool isSignIn = false;
        Account_SignIn signInForm = new Account_SignIn() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        Account_SignUp signUpForm = new Account_SignUp() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        public Account_Insert()
        {
            InitializeComponent();
            isSignIn = true;
        }

        public void ReplaceSignUpForm()
        {
            signInForm.Hide();
            signUpForm.Show();
            isSignIn = false;
        }

        public void ReplaceSignInForm()
        {
            signUpForm.Hide();
            signInForm.Show();
            isSignIn = true;
        }

        private void Account_Insert_Load(object sender, EventArgs e)
        {
            this.panelAccount_Insert.Controls.Add(signInForm);
            this.panelAccount_Insert.Controls.Add(signUpForm);
            signInForm.Show();
            isSignIn = true;
        }

        private void exitBtn_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!isSignIn)
            {
                ReplaceSignInForm();
                return;
            }

            //Check if account is correct
            string username = signInForm.txtUserName;

            if (username == "")
            {
                Validate_Notification notification = new Validate_Notification();
                notification.validate_Lable = "Wrong user name or password";
                notification.ShowDialog();
                return;
            }

            util.user = util.GetUserWhenLogin(username);

            if (util.user != null && signInForm.txtPassword == util.user.password
                    && signInForm.role == util.user.role)
            {
                //Sign in success
                util.userName = signInForm.txtUserName;

                this.Hide();
                //Get User (Set util and show form)
                switch (util.user.role)
                {
                    case "student":
                        AbstractUserClass student = new StudentClass();
                        student.SetUtil();
                        break;
                    case "employer":
                        AbstractUserClass employer = new EmployerClass();
                        employer.SetUtil();
                        break;
                    case "admin":
                        AbstractUserClass admin = new AdminClass();
                        admin.SetUtil();
                        break;
                }
                this.Close();
            }
            else
            {
                // Sign in Error
                Validate_Notification notification = new Validate_Notification();
                if (util.user == null || signInForm.txtPassword != util.user.password)
                {
                    notification.validate_Lable = "Wrong user name or password";
                }
                else if (signInForm.role == null)
                {
                    notification.validate_Lable = "Please choose your account type";
                }
                else if (signInForm.role != util.user.role)
                {
                    notification.validate_Lable = "Wrong account type, choose another account type";
                }
                notification.ShowDialog();
                return;
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (isSignIn)
            {
                ReplaceSignUpForm();
                return;
            }

            Validate_Notification notification = new Validate_Notification();
            if (signUpForm.txtUserName == "")
            {
                notification.validate_Lable = "Please input user name";
                notification.ShowDialog();
                return;
            }
            if (signUpForm.txtPassword.Count() < 8)
            {
                notification.validate_Lable = "Pawword must have aleast 8 character";
                notification.ShowDialog();
                return;
            }
            else if (signUpForm.txtRePassword != signUpForm.txtPassword)
            {
                notification.validate_Lable = "Please reinput right password";
                notification.ShowDialog();
                return;
            }
            else if (signUpForm.role == null)
            {
                notification.validate_Lable = "Please input account type";
                notification.ShowDialog();
                return;
            }

            //Sign up success
            util.userName = signUpForm.txtUserName;
            util.password = signUpForm.txtPassword;
            util.role = signUpForm.role;

            switch (signUpForm.role)
            {
                case "student":
                    AbstractUserClass student = new StudentClass();
                    student.InsertUser();
                    break;
                case "employer":
                    AbstractUserClass employer = new EmployerClass();
                    employer.InsertUser();
                    break;
                case "admin":
                    AbstractUserClass admin = new AdminClass();
                    admin.InsertUser();
                    break;
            }
            Register_Notifycation register_Notifycation = new Register_Notifycation();
            register_Notifycation.ShowDialog();

        }
    }
}
