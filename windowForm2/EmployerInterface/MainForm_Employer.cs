using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windowForm2.EmployerInterface
{
    public partial class MainForm_Employer : Form
    {
        Employer_Candidate employerHome;
        Employer_EventManager employerEventManager;
        Employer_InformationRegister employerInformationRegister;

        public MainForm_Employer()
        {
            InitializeComponent();

            //Give jobList to the orther form in order to get inf from the jobList
            employerHome = new Employer_Candidate() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            employerEventManager = new Employer_EventManager() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            employerInformationRegister = new Employer_InformationRegister() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };

            this.BackColor = Color.FromArgb(251, 35, 75);

        }

        private void MainForm_Employer_Load(object sender, EventArgs e)
        {
            this.panelContent.Controls.Add(employerHome);
            this.panelContent.Controls.Add(employerEventManager);
            this.panelContent.Controls.Add(employerInformationRegister);
            employerHome.Show();
        }

        private void eventManageBtn_Click(object sender, EventArgs e)
        {
            employerHome.Hide();
            employerEventManager.Show();
        }

        private void changeInformationBtn_Click(object sender, EventArgs e)
        {
            employerHome.Hide();
            employerEventManager.Hide();
            employerInformationRegister.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Account_Insert account_Insert_Form = new Account_Insert();
            account_Insert_Form.ShowDialog();
            this.Close();
        }

        private void btnCandidate_Click(object sender, EventArgs e)
        {
            employerHome.Show();
        }
    }
}
