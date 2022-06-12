using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using windowForm2.Bridge;
using windowForm2.Classes;
using windowForm2.Business;
using windowForm2.Global;

namespace windowForm2.StudentInterfaces
{
    public partial class JobDetail_Form : Form
    {
        JOB job;
        AbstractManager manager;
        BLStudentApplied blStudentApplied;

        public JobDetail_Form(JOB job)
        {
            InitializeComponent();
            this.job = job;
            EMPLOYER employer = util.GetEmployer((int)job.employerID);
            lbJobName.Text = job.jobName;
            lbComName.Text = employer.employerName;
            lbWage.Text = job.wagePerHour.ToString();
            lbAddress.Text = job.address;
            lbJobDescription.Text = job.jobDescription;
            this.Padding = new Padding(2);
            this.BackColor = Color.FromArgb(253, 202, 155);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            util.jobID = job.ID;
            util.jobName = job.jobName;
            //Already have util.studentID when login
            //Put jobID and StudentID to studentApplied table
            blStudentApplied = new BLStudentApplied();
            manager = new AbstractManager(blStudentApplied);
            manager.Insert();
            MessageBox.Show("Apply complete, your information had been sent to employer");
        }
    }
}
