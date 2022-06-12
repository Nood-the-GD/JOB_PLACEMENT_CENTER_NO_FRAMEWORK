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
using windowForm2.Bridge;
using windowForm2.Business;

namespace windowForm2.StudentInterfaces
{
    public partial class StudentApplied_Form : Form
    {
        public StudentApplied_Form()
        {
            InitializeComponent();
            LoadData();
        }

        void LoadData()
        {
            DataSet dataSet = new DataSet();
            dataSet = util.GetStudentAppliedListBasedOnStudentID(util.studentID);

            dgvAppliedJob.DataSource = dataSet.Tables[0];
        }

        private void StudentApplied_Form_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvAppliedJob_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvAppliedJob.CurrentCell.RowIndex;
            util.studentAppliedID = Convert.ToInt32(dgvAppliedJob.Rows[r].Cells[0].Value.ToString());
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            AbstractManager manger = new AbstractManager(new BLStudentApplied());
            manger.Delete();
            LoadData();
        }
    }
}
