using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentBillingLibrary
{
    public class BillItem
    {
        public int Bill_Id { get; set; }
        public int Bill_Std_Id { get; set; }
        public string Bill_Description { get; set; }
        public decimal Bill_TotalAmount { get; set; }
        public decimal Bill_FinalAmount { get; set; }
        public double Bill_Discount { get; set; }
        public string Bill_Status { get; set; }
        public decimal Bill_PaymentMade { get; set; }
        public string Bill_DatePaid { get; set; }
        public decimal Bill_Balance { get; set; }
        public string Bill_Semester { get; set; }
        public string Bill_SchoolYear { get; set; }
        public string Bill_DueDate { get; set; }
        public string Bill_IsOld { get; set; }
        public string Bill_Deleted { get; set; }

    }
}
