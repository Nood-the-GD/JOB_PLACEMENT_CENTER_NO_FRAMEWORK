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
    public partial class Employer_EventManager : Form
    {
        DataSet jobList;

        AbstractManager manager;
        BLJob blJob;

        //This form use to see and add the job of this company.
        public Employer_EventManager()
        {

            InitializeComponent();
            blJob = new BLJob();
            manager = new AbstractManager(blJob);
            LoadData();

            //Set all input disable
            txtJobName.Enabled = false;
            txtAddress.Enabled = false;
            txtDescription.Enabled = false;
            txtWagePerHour.Enabled = false;
            btnAdd.Enabled = false;
            btnCancel.Enabled = false;
        }

        void LoadData()
        {
            //Get emID -> Geted when login
            //Get List of Job base on emID
            jobList = util.GetJobList(util.employerID);

            //Show List on UI
            dgvJobEvent.DataSource = jobList.Tables[0];
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Set all input enable
            txtJobName.Enabled = true;
            txtAddress.Enabled = true;
            txtDescription.Enabled = true;
            txtWagePerHour.Enabled = true;
            btnAdd.Enabled = true;
            btnCancel.Enabled = true;

            txtJobName.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtSearch.Focus();
            //Set all input disable
            txtJobName.Enabled = false;
            txtAddress.Enabled = false;
            txtDescription.Enabled = false;
            txtWagePerHour.Enabled = false;
            btnAdd.Enabled = false;
            btnCancel.Enabled = false;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            manager.Delete(); //Delete job based on jobID
            //When employer delete a job, that job also be deleted in studentApplied table.
            DataSet ds = new DataSet();
            ds = util.GetStudentAppliedList(util.jobID); //Get the list studentApplied based on jobID to delete
            foreach(DataRow stuApplied in ds.Tables[0].Rows)
            {
                util.studentAppliedID = Convert.ToInt32(stuApplied["ID"].ToString());
                manager = new AbstractManager(new BLStudentApplied());
                manager.Delete();
            }

            LoadData();
        }

        private void btnComfirm_Click(object sender, EventArgs e)
        {
            util.jobName = txtJobName.Text;
            util.wagePerHours = Convert.ToInt32(txtWagePerHour.Text);
            util.address = txtAddress.Text;
            util.jobDescription = txtDescription.Text;

            manager.Insert();
            LoadData();
        }

        private void dgvJobEvent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = Convert.ToInt32(dgvJobEvent.CurrentCell.RowIndex);
            int jobID = Convert.ToInt32(dgvJobEvent.Rows[r].Cells[0].Value.ToString());

            util.jobID = jobID;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataSet oldData = jobList;
            DataSet result = new DataSet();

            result = util.SearchJobBaseOnKeyWord(txtSearch.Text, util.employerID);
            dgvJobEvent.DataSource = result;
        }
    }
}
