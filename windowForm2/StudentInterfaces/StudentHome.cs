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
    public partial class StudentHome : Form
    {
        //This form use to see all the job
        AbstractManager manager;
        BLJob blJob;

        public StudentHome()
        {
            InitializeComponent();
            blJob = new BLJob();
            manager = new AbstractManager(blJob);

            //Show job list to UI
            dgvJobList.DataSource = manager.GetTable();
        }

        private void StudentHome_Load(object sender, EventArgs e)
        {
            dgvJobList.DataSource = manager.GetTable();
        }

        private void dgvJobList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvJobList.CurrentCell.RowIndex;
            int jobID = Convert.ToInt32(dgvJobList.Rows[r].Cells[0].Value.ToString());
            util.jobID = jobID;
            JOB job = util.GetJob(jobID);
            JobDetail_Form jobDetail_Form = new JobDetail_Form(job);
            jobDetail_Form.ShowDialog();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            manager.Search(dgvJobList, txtSearch.Text);
            if(txtSearch.Text == "")
            {
                dgvJobList.DataSource = manager.GetTable();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            DataTable data = new DataTable();
            string condition = "";
            //Search Place
            string address = cbPlace.Text.Trim();
            condition = "address LIKE " + address + "% ";
            //Search salary
            switch (cbSalary.Text)
            {
                case "< 50.000đ":
                    condition += "OR wagePerHour < 50000" ;
                    break;
                case "50.000 - 100.000đ":
                    condition += "OR wagePerHour > 50000 OR wagePerHour < 100000";
                    break;
                case "100.000 - 200.000đ":
                    condition += "OR wagePerHour > 100000 OR wagePerHour < 200000";
                    break;
                case "> 200.000đ":
                    condition += "OR wagePerHour > 200000";
                    break;
            }

            string sqlStr = "Select * from JOB where " + condition;
            ds = DBMain.ExecuteQueryDataSet(sqlStr, CommandType.Text);
            data = ds.Tables[0];
            dgvJobList.DataSource = data;
        }
    }
}
