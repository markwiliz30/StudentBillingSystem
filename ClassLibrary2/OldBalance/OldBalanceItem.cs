using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentBillingLibrary
{
    public class OldBalanceItem
    {
        public int OldFees_Id { get; set; }
        public int OldFees_Std_Id { get; set; }
        public int OldFees_Bill_Id { get; set; }
        public string OldFees_Description { get; set; }
        public int OldFees_PaymentNumber { get; set; }
        public decimal OldFees_Amount { get; set; }
        public decimal OldFees_Payment { get; set; }
        public string OldFees_DatePaid { get; set; }
        public decimal OldFees_PaymentMade { get; set; }
        public decimal OldFees_Balance { get; set; }
        public bool OldFees_Status { get; set; }
        public string OldFees_Deleted { get; set; }
    }
}
