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
    internal class BLUser : BusinessLayer
    {
        string TABLE_NAME = "USERS";
        public bool Delete()
        {
            string sqlString = "Delete " + TABLE_NAME + " where ID=" + util.userID;
            DBMain.MyExecuteNonQuery(sqlString, CommandType.Text);
            return true;
        }

        public bool DeleteBaseOnUseID()
        {
            string sqlString = "Delete " + TABLE_NAME + " where ID=" + util.userID;
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
               util.userName + "', '" +
               util.password + "', '" +
               util.role + "')";
            DBMain.MyExecuteNonQuery(sqlString, CommandType.Text);
            return true;
        }

        public void Search(DataGridView dgv, string searchKeyWord)
        {
            string sqlString = "SELECT * FROM " + TABLE_NAME + " WHERE username LIKE '" + searchKeyWord + "%'";
            var result = DBMain.ExecuteQueryDataSet(sqlString, CommandType.Text);
            dgv.DataSource = result;
        }

        public bool Update()
        {
            string sqlString = "Update " + TABLE_NAME + " Set username='" +
                util.userName + "', password='" +
                util.password + "', role='" +
                util.role +
                "' where ID=" + util.userID;
            DBMain.MyExecuteNonQuery(sqlString, CommandType.Text);
            return true;
        }
    }
}
