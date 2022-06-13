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
    internal class BLEmployer : BusinessLayer
    {
        string TABLE_NAME = "EMPLOYER";
        public bool Delete()
        {
            string sqlString = "Delete " + TABLE_NAME + " where ID=" + util.employerID;
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
            string sqlString = "Insert Into " + TABLE_NAME + " Values('" +
               util.emName + "', '" +
               util.address + "', '" +
               util.phoneNumber + "', " +
               util.userID + ")";
            DBMain.MyExecuteNonQuery(sqlString, CommandType.Text);
            return true;
        }

        public void Search(DataGridView dgv, string searchKeyWord)
        {
            string sqlString = "SELECT * FROM " + TABLE_NAME + " WHERE emloyerName LIKE '%" + searchKeyWord + "%'";
            var result = DBMain.ExecuteQueryDataSet(sqlString, CommandType.Text);
            dgv.DataSource = result;
        }

        public bool Update()
        {
            string sqlString = "Update " + TABLE_NAME + " Set employerName='" +
                util.emName + "', address='" +
                util.address + "', phoneNumber='" +
                util.phoneNumber + "', userID= " +
                util.userID +
                " where ID=" + util.employerID;
            DBMain.MyExecuteNonQuery(sqlString, CommandType.Text);
            return true;
        }
    }
}
