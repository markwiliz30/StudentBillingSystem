using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentBillingLibrary
{
    public class StudentItem
    {
        public int Std_Id { get; set; }
        public string Std_FName { get; set; }
        public string Std_MName { get; set; }
        public string Std_LName { get; set; }
        public string Std_CourseCode { get; set; }
        public string Std_CourseTitle { get; set; }
        public string Std_Section { get; set; }
        public string Std_Year { get; set; }
        public string Std_Deleted { get; set; }

    }
}
