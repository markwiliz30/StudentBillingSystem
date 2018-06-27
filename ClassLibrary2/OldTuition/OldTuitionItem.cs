using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentBillingLibrary
{
    public class OldTuitionItem
    {
        public int OldTuition_Id { get; set; }
        public int OldTuition_Bill_Id { get; set; }
        public int OldTuition_Std_Id { get; set; }
        public string OldTuition_Description { get; set; }
        public decimal OldTuition_Amount { get; set; }
        public decimal OldTuition_Balance { get; set; }
        public string OldTuition_DatePaid { get; set; }
        public decimal OldTuition_PayMade { get; set; }
        public string OldTuition_Status { get; set; }
        public string OldTuition_Deleted { get; set; }
    }
}
