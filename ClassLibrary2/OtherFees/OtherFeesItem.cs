using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentBillingLibrary
{
    public class OtherFeesItem
    {
        public int OtherFees_Id { get; set; }
        public int OtherFees_Bill_Id { get; set; }
        public int OtherFees_Std_Id { get; set; }
        public string OtherFees_Description { get; set; }
        public decimal OtherFees_Amount { get; set; }
        public decimal OtherFees_Balance { get; set; }
        public string OtherFees_DueDate { get; set; }
        public string OtherFees_DatePaid { get; set; }
        public decimal OtherFees_PaymentMade { get; set; }
        public string OtherFees_CutOffDate { get; set; }
        public string OtherFees_Status { get; set; }
        public string OtherFees_IsOld { get; set; }
        public string OtherFees_Deleted { get; set; }
    }
}
