using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentBillingLibrary
{
    public class OtherFeesPaymentItem
    {
        public int OtherPay_Id { get; set; }
        public int OtherPay_OtherFees_Id { get; set; }
        public int OtherPay_Bill_Id { get; set; }
        public int OtherPay_Std_Id { get; set; }
        public int OtherPay_Number { get; set; }
        public decimal OtherPay_Paid { get; set; }
        public string OtherPay_DatePaid { get; set; }
        public string OtherPay_IsOld { get; set; }
        public string OtherPay_Deleted { get; set; }
    }
}
