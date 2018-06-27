using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentBillingLibrary
{
    public class PartialPaymentItem
    {
        public int PartPay_Id { get; set; }
        public int PartPay_Bill_Id { get; set; }
        public int PartPay_Std_Id { get; set; }
        public string PartPay_Partition { get; set; }
        public decimal PartPay_Amount { get; set; }
        public decimal PartPay_Balance { get; set; }
        public string PartPay_DueDate { get; set; }
        public string PartPay_DatePaid { get; set; }
        public decimal PartPay_PaymentMade { get; set; }
        public string PartPay_Status { get; set; }
        public string PartPay_Deleted { get; set; }
    }
}
