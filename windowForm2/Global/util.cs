using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using windowForm2.Classes;
using windowForm2.Business;

namespace windowForm2.Global
{
    public static class util
    {
        public static USER user;

        public static string userName;
        public static string password;
        public static string role;

        public static int userID;
        public static int studentID;
        public static int employerID;
        public static int jobID;
        public static int studentAppliedID;
        public static int jobAppliedID;

        public static string jobDescription;
        public static int wagePerHours;
        public static string stDateOfBirth;
        public static string address;
        public static string gender;
        public static string phoneNumber;
        public static string healthCondition;
        public static string additionalCondition;
        public static string jobStatus = "None";

        public static string emName;
        public static string stfullName;
        public static string jobName;

        public static List<EMPLOYER> employerTable;
        public static List<STUDENT> studentTable;
        public static List<JOB> jobTable;
        public static List<USER> userTable;
        public static List<studentApplied> studentAppliedTable;


        public static EMPLOYER GetEmployer(int employerID)
        {
            EMPLOYER em = new EMPLOYER();
            DataSet ds = new DataSet();
            string sqlStr = "Select * from EMPLOYER where ID=" + employerID + "";
            ds = DBMain.ExecuteQueryDataSet(sqlStr, CommandType.Text);
            em.ID = Convert.ToInt32(ds.Tables[0].Rows[0]["ID"].ToString());
            em.employerName = ds.Tables[0].Rows[0]["employerName"].ToString();
            em.phoneNumber = ds.Tables[0].Rows[0]["phoneNumber"].ToString();
            em.address = ds.Tables[0].Rows[0]["address"].ToString();
            em.userID = ds.Tables[0].Rows[0]["userID"].ToString();
            return em;
        }

        public static EMPLOYER GetEmployerBaseOnUserID(int userID)
        {
            EMPLOYER em = new EMPLOYER();
            DataSet ds = new DataSet();
            string sqlStr = "Select * from EMPLOYER where userID=" + userID + "";
            ds = DBMain.ExecuteQueryDataSet(sqlStr, CommandType.Text);
            em.ID = Convert.ToInt32(ds.Tables[0].Rows[0]["ID"].ToString());
            em.employerName = ds.Tables[0].Rows[0]["employerName"].ToString();
            em.phoneNumber = ds.Tables[0].Rows[0]["phoneNumber"].ToString();
            em.address = ds.Tables[0].Rows[0]["address"].ToString();
            em.userID = ds.Tables[0].Rows[0]["userID"].ToString();
            return em;
        }

        public static STUDENT GetStudent(int studentID)
        {
            STUDENT stu = new STUDENT();
            DataSet ds = new DataSet();
            string sqlStr = "Select * from STUDENT where ID=" + studentID + "";
            ds = DBMain.ExecuteQueryDataSet(sqlStr, CommandType.Text);

            stu.ID = Convert.ToInt32(ds.Tables[0].Rows[0]["ID"].ToString());
            stu.fullName = ds.Tables[0].Rows[0]["fullName"].ToString();
            stu.dateOfBirth = ds.Tables[0].Rows[0]["dateOfBirth"].ToString();
            stu.address = ds.Tables[0].Rows[0]["address"].ToString();
            stu.gender = ds.Tables[0].Rows[0]["gender"].ToString();
            stu.phoneNumber = ds.Tables[0].Rows[0]["phoneNumber"].ToString();
            stu.healthCondition = ds.Tables[0].Rows[0]["healthCondition"].ToString();
            stu.additionalCondition = ds.Tables[0].Rows[0]["additionalCondition"].ToString();
            return stu;
        }

        public static STUDENT GetStudentBaseOnUserID(int userID)
        {
            STUDENT stu = new STUDENT();
            DataSet ds = new DataSet();
            string sqlStr = "Select * from STUDENT where userID=" + userID;
            ds = DBMain.ExecuteQueryDataSet(sqlStr, CommandType.Text);

            stu.ID = Convert.ToInt32(ds.Tables[0].Rows[0]["ID"].ToString());
            stu.fullName = ds.Tables[0].Rows[0]["fullName"].ToString();
            stu.dateOfBirth = ds.Tables[0].Rows[0]["dateOfBirth"].ToString();
            stu.address = ds.Tables[0].Rows[0]["address"].ToString();
            stu.gender = ds.Tables[0].Rows[0]["gender"].ToString();
            stu.phoneNumber = ds.Tables[0].Rows[0]["phoneNumber"].ToString();
            stu.healthCondition = ds.Tables[0].Rows[0]["healthCondition"].ToString();
            stu.additionalCondition = ds.Tables[0].Rows[0]["additionalCondition"].ToString();
            return stu;
        }

        public static JOB GetJob(int jobID)
        {
            JOB job = new JOB();
            DataSet ds = new DataSet();
            string sqlStr = "Select * from JOB where ID=" + jobID;
            ds = DBMain.ExecuteQueryDataSet(sqlStr, CommandType.Text);

            job.ID = Convert.ToInt32(ds.Tables[0].Rows[0]["ID"].ToString());
            job.employerID = Convert.ToInt32(ds.Tables[0].Rows[0]["employerID"].ToString());
            job.jobName = ds.Tables[0].Rows[0]["jobName"].ToString();
            job.jobDescription = ds.Tables[0].Rows[0]["jobDescription"].ToString();
            job.address = ds.Tables[0].Rows[0]["address"].ToString();
            job.wagePerHour = Convert.ToInt32(ds.Tables[0].Rows[0]["wagePerHour"].ToString());
            return job;
        }

        public static DataSet GetJobList(int emID)
        {
            List<JOB> jobList = new List<JOB>();
            DataSet ds = new DataSet();
            string sqlStr = "Select * from JOB where employerID=" + emID + "";
            ds = DBMain.ExecuteQueryDataSet(sqlStr, CommandType.Text);
            
            return ds;
        }

        public static USER GetUser(int userID)
        {
            USER user = new USER();
            DataSet ds = new DataSet();
            string sqlStr = "Select * from USER where ID=" + userID + "'";
            ds = DBMain.ExecuteQueryDataSet(sqlStr, CommandType.Text);
            user.ID = Convert.ToInt32(ds.Tables[0].Rows[0]["ID"].ToString());
            user.userName = ds.Tables[0].Rows[0]["username"].ToString();
            user.password = ds.Tables[0].Rows[0]["password"].ToString();
            user.role = ds.Tables[0].Rows[0]["role"].ToString();
            return user;
        }

        public static USER GetUserWhenLogin(string userName)
        {
            USER user = new USER();
            try
            {
                DataSet ds = new DataSet();
                string sqlStr = "Select * from USERS where username='" + userName + "'";
                ds = DBMain.ExecuteQueryDataSet(sqlStr, CommandType.Text);
                user.ID = Convert.ToInt32(ds.Tables[0].Rows[0]["ID"].ToString());
                user.userName = ds.Tables[0].Rows[0]["username"].ToString();
                user.password = ds.Tables[0].Rows[0]["password"].ToString();
                user.role = ds.Tables[0].Rows[0]["role"].ToString();
                return user;

            }
            catch(Exception ex)
            {
                return null;
            }
            
        }

        public static DataSet GetStudentAppliedList(int jobID)
        {
            DataSet ds = new DataSet();
            string sqlStr = "Select * from studentApplied where jobID=" + jobID + "";
            ds = DBMain.ExecuteQueryDataSet(sqlStr, CommandType.Text);

            return ds;
        }

        public static DataSet GetStudentAppliedListBasedOnStudentID(int stuID)
        {
            DataSet ds = new DataSet();
            string sqlStr = "Select * from studentApplied where studentID=" + stuID + "";
            ds = DBMain.ExecuteQueryDataSet(sqlStr, CommandType.Text);

            return ds;
        }

        public static bool DeleteAppliedBasedOnStudentID(int stuID)
        {
            string sqlString = "Delete studentApplied where studentID=" + stuID;
            DBMain.MyExecuteNonQuery(sqlString, CommandType.Text);
            return true;
        }

        public static bool DeleteAppliedBasedOnJobID(int jobID)
        {
            string sqlString = "Delete studentApplied where jobID=" + jobID;
            DBMain.MyExecuteNonQuery(sqlString, CommandType.Text);
            return true;
        }

        public static bool DeleteJobBaseOnEmID(int emID)
        {
            string sqlString = "Delete JOB where employerID=" + emID;
            DBMain.MyExecuteNonQuery(sqlString, CommandType.Text);
            return true;
        }

        public static studentApplied GetStudentApplied(int studentAppliedID)
        {
            studentApplied stuApplied = new studentApplied();
            DataSet ds = new DataSet();
            string sqlStr = "Select * from studentApplied where ID=" + studentAppliedID + "";
            ds = DBMain.ExecuteQueryDataSet(sqlStr, CommandType.Text);

            stuApplied.ID = Convert.ToInt32(ds.Tables[0].Rows[0]["ID"].ToString());
            stuApplied.studentID = Convert.ToInt32(ds.Tables[0].Rows[0]["studentID"].ToString());
            stuApplied.jobID = Convert.ToInt32(ds.Tables[0].Rows[0]["jobID"].ToString());
            stuApplied.jobName = ds.Tables[0].Rows[0]["jobName"].ToString();
            stuApplied.status = ds.Tables[0].Rows[0]["status"].ToString();

            return stuApplied;
        }

        public static DataSet SearchStudentAppliedBaseOnKeyWord(string keyWord, int jobID)
        {
            DataSet ds = new DataSet();
            string sqlStr = "SELECT * FROM studentApplied WHERE jobName LIKE %'" + keyWord + "'% AND jobID = " + jobID;
            ds = DBMain.ExecuteQueryDataSet(sqlStr, CommandType.Text);
            return ds;
        }

        public static DataSet SearchJobBaseOnKeyWord(string keyWord, int emID)
        {
            DataSet ds = new DataSet();
            string sqlStr = "SELECT * FROM JOB WHERE jobDescription LIKE %'" + keyWord + "'% OR jobName LIKE %'" + keyWord + "'% AND employerID = " + emID;
            ds = DBMain.ExecuteQueryDataSet(sqlStr, CommandType.Text);
            return ds;
        }

        public static int GetUserNumber()
        {
            DataSet ds = new DataSet();
            string sqlStr = "SELECT * FROM USERS";
            ds = DBMain.ExecuteQueryDataSet(sqlStr, CommandType.Text);
            return ds.Tables[0].Rows.Count;
        }

        public static int GetStudentNumber()
        {
            DataSet ds = new DataSet();
            string sqlStr = "SELECT * FROM STUDENT";
            ds = DBMain.ExecuteQueryDataSet(sqlStr, CommandType.Text);
            return ds.Tables[0].Rows.Count;
        }

        public static int GetEmployerNumber()
        {
            DataSet ds = new DataSet();
            string sqlStr = "SELECT * FROM EMPLOYER";
            ds = DBMain.ExecuteQueryDataSet(sqlStr, CommandType.Text);
            return ds.Tables[0].Rows.Count;
        }

        public static int GetJobNumber()
        {
            DataSet ds = new DataSet();
            string sqlStr = "SELECT * FROM JOB";
            ds = DBMain.ExecuteQueryDataSet(sqlStr, CommandType.Text);
            return ds.Tables[0].Rows.Count;
        }

        public static int GetStudentAppliedNumber()
        {
            DataSet ds = new DataSet();
            string sqlStr = "SELECT * FROM studentApplied";
            ds = DBMain.ExecuteQueryDataSet(sqlStr, CommandType.Text);
            return ds.Tables[0].Rows.Count;
        }
    }
}
