using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windowForm2.StudentInterfaces
{
    public partial class MainForm_Student : Form
    {
        StudentHome studentHomeForm;
        Student_CV_Form studentCVForm;
        StudentApplied_Form studentAppliedForm;

        public MainForm_Student()
        {
            InitializeComponent();

            studentHomeForm = new StudentHome() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            studentCVForm = new Student_CV_Form() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            studentAppliedForm = new StudentApplied_Form() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.BackColor = Color.FromArgb(253, 202, 155);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.panelContent.Controls.Add(studentHomeForm);
            this.panelContent.Controls.Add(studentCVForm);
            this.panelContent.Controls.Add(studentAppliedForm);
            studentHomeForm.Show();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            studentHomeForm.Show();
        }

        private void manageCVBtn_Click(object sender, EventArgs e)
        {
            studentHomeForm.Hide();
            studentCVForm.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Account_Insert account_Insert_Form = new Account_Insert();
            account_Insert_Form.ShowDialog();
            this.Close();
        }

        private void btnAppliedJob_Click(object sender, EventArgs e)
        {
            studentHomeForm.Hide();
            studentCVForm.Hide();
            studentAppliedForm.Show();
        }
    }
}
