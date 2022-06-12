using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using windowForm2.Classes;
using windowForm2.Business;
using windowForm2.Bridge;
using windowForm2.Global;

namespace windowForm2.EmployerInterface
{
    public partial class Employer_StudentDetail : Form
    {
        AbstractManager manager;
        BLStudentApplied blStudentApplied;
        studentApplied stApplied;

        public Employer_StudentDetail(STUDENT student, studentApplied studentApplied)
        {
            InitializeComponent();
            stApplied = studentApplied;
            util.studentAppliedID = studentApplied.ID;
            blStudentApplied = new BLStudentApplied();
            manager = new AbstractManager(blStudentApplied);
            //When load, use information in util class to show in CV zone
            txtFullName.Text = student.fullName;
            txtID.Text = student.ID.ToString().Trim();
            txtDateOfBirth.Text = student.dateOfBirth;
            txtPhone.Text = student.phoneNumber;
            txtAddress.Text = student.address;
            txtGender.Text = student.gender;
            txtHealthCondition.Text = student.healthCondition;
            txtAdditionalCondition.Text = student.additionalCondition;
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            util.jobStatus = "Approved";
            util.jobID = (int)stApplied.jobID;
            util.studentID = (int)stApplied.studentID;
            util.jobName = stApplied.jobName;
            manager.Update();
        }

        private void btnDecline_Click(object sender, EventArgs e)
        {
            util.jobStatus = "Decline";
            util.jobID = (int)stApplied.jobID;
            util.studentID = (int)stApplied.studentID;
            util.jobName = stApplied.jobName;
            manager.Update();
        }

        private void Employer_StudentDetail_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
