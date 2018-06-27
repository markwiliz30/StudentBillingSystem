using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentBillingLibrary
{
    public class PaymentItem
    {
        public int Payment_Id { get; set; }
        public int Payment_PartPay_Id { get; set; }
        public int Payment_Bill_Id { get; set; }
        public int Payment_Std_Id { get; set; }
        public int Payment_Number { get; set; }
        public decimal Payment_Paid { get; set; }
        public string Payment_DatePaid { get; set; }
        public string Payment_IsOld { get; set; }
        public string Payment_Deleted { get; set; }

    }
}
