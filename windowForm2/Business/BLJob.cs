using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using windowForm2.Global;
using windowForm2.Bridge;

namespace windowForm2.Business
{
    internal class BLJob : BusinessLayer
    {
        string TABLE_NAME = "JOB";
        public bool Delete()
        {
            string sqlString = "Delete " + TABLE_NAME + " where ID=" + util.jobID ;
            DBMain.MyExecuteNonQuery(sqlString, CommandType.Text);
            return true;
        }

        public bool DeleteBaseOnUseID()
        {
            return true;
        }

        public DataSet GetTable()
        {
            string sqlString = "Select * from " + TABLE_NAME + "";
            return DBMain.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }

        public bool Insert()
        {
            string sqlString = "Insert Into " + TABLE_NAME + " Values(" +
               util.employerID + ", N'" +
               util.jobName + "', N'" +
               util.jobDescription + "', N'" +
               util.address + "', " +
               util.wagePerHours + ")";
            DBMain.MyExecuteNonQuery(sqlString, CommandType.Text);
            return true;
        }

        public void Search(DataGridView dgv, string searchKeyWord)
        {
            string sqlString = "SELECT * FROM " + TABLE_NAME + " WHERE jobName LIKE '" + searchKeyWord + "%'";
            var result = DBMain.ExecuteQueryDataSet(sqlString, CommandType.Text);
            dgv.DataSource = result;
        }

        public bool Update()
        {
            string sqlString = "Update " + TABLE_NAME + " Set employerID=" +
                util.employerID + ", jobName=N'" +
                util.jobName + "', jobDescription=N'" +
                util.jobDescription + "', address=N'" +
                util.address + "', wagePerHour=" +
                util.wagePerHours + 
                " where ID=" + util.jobID;
            DBMain.MyExecuteNonQuery(sqlString, CommandType.Text);
            return true;
        }
    }
}
