using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using windowForm2.Global;
using windowForm2.Bridge;

namespace windowForm2.Business
{
    internal class BLStudent:BusinessLayer
    {
        string TABLE_NAME = "STUDENT";
        public bool Delete()
        {
            string sqlString = "Delete " + TABLE_NAME + " where ID=" + util.studentID;
            DBMain.MyExecuteNonQuery(sqlString, CommandType.Text);
            return true;
        }

        public bool DeleteBaseOnUseID()
        {
            string sqlString = "Delete " + TABLE_NAME + " where userID=" + util.userID;
            DBMain.MyExecuteNonQuery(sqlString, CommandType.Text);
            return true;
        }

        public DataSet GetTable()
        {
            string sqlString = "Select * from " + TABLE_NAME + "";
            return DBMain.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }

        public bool Insert()
        {
            string sqlString = "Insert Into " + TABLE_NAME + " Values(N'" +
               util.stfullName + "', '" +
               util.stDateOfBirth + "', N'" +
               util.address + "', N'" +
               util.gender + "', '" +
               util.phoneNumber + "', N'" +
               util.healthCondition + "', N'" +
               util.additionalCondition + "', " +
               util.userID + ")";
            DBMain.MyExecuteNonQuery(sqlString, CommandType.Text);
            return true;
        }

        public void Search(DataGridView dgv, string searchKeyWord)
        {
            string sqlString = "SELECT * FROM " + TABLE_NAME + " WHERE fullName LIKE '%" + searchKeyWord + "%'";
            var result = DBMain.ExecuteQueryDataSet(sqlString, CommandType.Text);
            dgv.DataSource = result;
        }

        public bool Update()
        {
            MessageBox.Show(util.studentID.ToString());
            string sqlString = "Update " + TABLE_NAME + " Set fullName=N'" +
                util.stfullName + "', dateOfBirth='" +
                util.stDateOfBirth + "', address=N'" +
                util.address + "', gender='" +
                util.gender + "', phoneNumber='" +
                util.phoneNumber + "', healthCondition=N'" +
                util.healthCondition + "', additionalCondition=N'" +
                util.additionalCondition +
                "' where ID=" + util.studentID;
            DBMain.MyExecuteNonQuery(sqlString, CommandType.Text);
            return true;
        }
    }
}
