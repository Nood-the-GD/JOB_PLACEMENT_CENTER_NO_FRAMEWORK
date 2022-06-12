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
using windowForm2.Business;
using windowForm2.Global;

namespace windowForm2.AdministratorInterface
{
    public partial class Administrator_ManageAccount : Form
    {
        AbstractManager manager, subManger;
        BLUser blUser;

        public Administrator_ManageAccount()
        {
            InitializeComponent();
            blUser = new BLUser();
            manager = new AbstractManager(blUser);

            //Show user table to UI
            dgvUserData.DataSource = manager.GetTable();
        }

        private void dgvUserData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Index of the current row
            int r = dgvUserData.CurrentCell.RowIndex;
            txtID.Text = dgvUserData.Rows[r].Cells[0].Value.ToString();
        }

        private void deleteAccountBtn_Click(object sender, EventArgs e)
        {
            util.userID = Convert.ToInt32(txtID.Text);
            manager.Delete();
            subManger = new AbstractManager(new BLStudent());
            subManger.DeleteBaseOnUserID();
            subManger = new AbstractManager(new BLEmployer());
            subManger.DeleteBaseOnUserID();
            dgvUserData.DataSource = manager.GetTable();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            manager.Search(dgvUserData, txtSearch.Text);
        }
    }
}
