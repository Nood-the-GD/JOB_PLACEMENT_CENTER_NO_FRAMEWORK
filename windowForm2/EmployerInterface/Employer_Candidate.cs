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
    public partial class Employer_Candidate : Form
    {
        //This form use to see list of student applied to this emplyer's job
        DataSet jobList = new DataSet();
        DataSet studentAppliedList = new DataSet();

        public Employer_Candidate()
        {
            InitializeComponent();
            LoadData();
        }

        private void dgvCandidateList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvCandidateList.CurrentCell.RowIndex;
            util.studentID = Convert.ToInt32(dgvCandidateList.Rows[r].Cells[1].Value.ToString());
            util.jobAppliedID = Convert.ToInt32(dgvCandidateList.Rows[r].Cells[0].Value.ToString());
            STUDENT student = util.GetStudent(util.studentID);
            studentApplied stApplied = util.GetStudentApplied(util.jobAppliedID);
            Employer_StudentDetail stuDetail_Form = new Employer_StudentDetail(student, stApplied);
            stuDetail_Form.ShowDialog();
            LoadData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void EmployerCandidate_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        void LoadData()
        {
            studentAppliedList.Clear();
            jobList.Clear();
            //Get the job list from DB
            jobList = util.GetJobList(util.employerID);
            //Base on jobID in the Job list -> get student who applied to the job
            foreach (DataRow job in jobList.Tables[0].Rows)
            {
                studentAppliedList.Merge(util.GetStudentAppliedList(Convert.ToInt32(job[0])));
            }
            //Show the studentAppliedList to the UIs
            dgvCandidateList.DataSource = studentAppliedList.Tables[0];
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataSet oldData = studentAppliedList;
            DataSet result = new DataSet();
            foreach (DataRow job in jobList.Tables[0].Rows)
            {
                result.Merge(util.SearchStudentAppliedBaseOnKeyWord(txtSearch.Text, Convert.ToInt32(job[0])));
            }
            dgvCandidateList.DataSource = result.Tables[0];

            if (txtSearch.Text == "")
            {
                dgvCandidateList.DataSource = oldData.Tables[0];
            }
        }
    }
}
