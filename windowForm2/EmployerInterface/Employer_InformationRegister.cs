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
using windowForm2.Classes;

namespace windowForm2.EmployerInterface
{
    public partial class Employer_InformationRegister : Form
    {
        AbstractManager manager;
        BLEmployer blEmplyer;

        public Employer_InformationRegister()
        {
            InitializeComponent();
            blEmplyer = new BLEmployer();
            manager = new AbstractManager(blEmplyer);
        }

        private void Employer_InformationRegister_Load(object sender, EventArgs e)
        {
            EMPLOYER em = util.GetEmployer(util.employerID);
            txtComName.Text = em.employerName;
            txtAddress.Text = em.address;
            txtPhoneNum.Text = em.phoneNumber;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            util.emName = txtComName.Text.Trim();
            util.address = txtAddress.Text.Trim();
            util.phoneNumber = txtPhoneNum.Text.Trim();

            manager.Update();
            Employer_InformationRegister_Load(sender, e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtComName.Clear();
            txtAddress.Clear();
            txtPhoneNum.Clear();
        }
    }
}
