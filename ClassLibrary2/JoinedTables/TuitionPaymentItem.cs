using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentBillingLibrary
{
    public class TuitionPaymentItem
    {
        public int PartPay_Id { get; set; }
        public string PartPay_Partition { get; set; }
        public decimal PartPay_Amount { get; set; }
        public int Payment_Number { get; set; }
        public decimal Payment_Paid { get; set; }
        public string Payment_DatePaid { get; set; }
        public decimal PartPay_Balance { get; set; }
        public decimal PartPay_PaymentMade { get; set; }
        public string PartPay_DueDate { get; set; }
        public string PartPay_Status { get; set; }

    }
}
