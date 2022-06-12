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
    public partial class Student_CV_Form : Form
    {
        AbstractManager manager;
        BLStudent blStudent;

        public Student_CV_Form()
        {
            InitializeComponent();
            blStudent = new BLStudent();
            manager = new AbstractManager(blStudent);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            util.stfullName = txtFullName.Text.Trim();

            if (rbMale.Checked == true)
            {
                util.gender = "male";
            }
            if (rbFemale.Checked == true)
            {
                util.gender = "female";
            }
            if (rbOther.Checked == true)
            {
                util.gender = "other";
            }

            util.stDateOfBirth = txtDateOfBirth.Text.Trim();
            util.address = txtAddress.Text.Trim();
            util.healthCondition = txtHealthCondition.Text.Trim();
            util.phoneNumber = txtPhoneNumber.Text.Trim();
            util.additionalCondition = txtAdditionalCondition.Text.Trim();

            manager.Update();
            Student_CV_Form_Load(sender, e);
        }

        private void Student_CV_Form_Load(object sender, EventArgs e)
        {
            util.GetStudent(util.studentID);
            //Show student information from util
            txtFullName.Text = util.stfullName;
            switch (util.gender)
            {
                case "male":
                    rbMale.Checked = true;
                    rbFemale.Checked = false;
                    rbOther.Checked = false;
                    break;
                case "female":
                    rbMale.Checked = false;
                    rbFemale.Checked = true;
                    rbOther.Checked = false;
                    break;
                case "other":
                    rbMale.Checked = false;
                    rbFemale.Checked = false;
                    rbOther.Checked = true;
                    break;
            }
            txtDateOfBirth.Text = util.stDateOfBirth;
            txtAddress.Text = util.address;
            txtHealthCondition.Text = util.healthCondition;
            txtPhoneNumber.Text = util.phoneNumber;
            txtAdditionalCondition.Text = util.additionalCondition;
        }
    }
}
