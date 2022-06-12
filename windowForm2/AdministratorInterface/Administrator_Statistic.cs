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

namespace windowForm2.AdministratorInterface
{
    public partial class Administrator_Statistic : Form
    {
        public Administrator_Statistic()
        {
            InitializeComponent();
            LoadData();
        }

        void LoadData()
        {
            userChart.Series["Number"].Points.Clear();
            //User column
            userChart.Series["Number"].Points.Add(util.GetUserNumber());
            userChart.Series["Number"].Points[0].Color = Color.Blue;
            userChart.Series["Number"].Points[0].AxisLabel = "User";
            userChart.Series["Number"].Points[0].LegendText = "User";
            userChart.Series["Number"].Points[0].Label = util.GetUserNumber().ToString();

            //Student column
            userChart.Series["Number"].Points.Add(util.GetStudentNumber());
            userChart.Series["Number"].Points[1].Color = Color.Orange;
            userChart.Series["Number"].Points[1].AxisLabel = "Student";
            userChart.Series["Number"].Points[1].LegendText = "Student";
            userChart.Series["Number"].Points[1].Label = util.GetStudentNumber().ToString();

            //Employer column
            userChart.Series["Number"].Points.Add(util.GetEmployerNumber());
            userChart.Series["Number"].Points[2].Color = Color.Red;
            userChart.Series["Number"].Points[2].AxisLabel = "Employer";
            userChart.Series["Number"].Points[2].LegendText = "Employer";
            userChart.Series["Number"].Points[2].Label = util.GetEmployerNumber().ToString();

            //Student Applied column
            userChart.Series["Number"].Points.Add(util.GetStudentAppliedNumber());
            userChart.Series["Number"].Points[3].Color = Color.Green;
            userChart.Series["Number"].Points[3].AxisLabel = "Student Applied";
            userChart.Series["Number"].Points[3].LegendText = "Student Applied";
            userChart.Series["Number"].Points[3].Label = util.GetStudentAppliedNumber().ToString();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
