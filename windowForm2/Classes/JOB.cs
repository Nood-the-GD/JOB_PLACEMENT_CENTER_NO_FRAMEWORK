using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace windowForm2.Classes
{
    public class JOB
    {
        public int ID { get; set; }
        public int employerID { get; set; }
        public string jobName { get; set; }
        public string jobDescription { get; set; }
        public string address { get; set; }
        public int wagePerHour { get; set; }
    }
}
