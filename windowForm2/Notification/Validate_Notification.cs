using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windowForm2.Notification
{
    public partial class Validate_Notification : Form
    {
        public Validate_Notification()
        {
            InitializeComponent();
        }

        public String validate_Lable
        {
            get { return validation_errorLabel.Text.Trim(); }
            set { validation_errorLabel.Text = value; }
        }
    }
}
