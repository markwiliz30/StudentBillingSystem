using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentBillingLibrary
{
    public class TuitionPaymentsOld
    {
        private List<PaymentItem> paymentCollect = new List<PaymentItem>();

        public List<PaymentItem> pubPaymentCollect
        {
            get { return paymentCollect; }
        }
        private List<PartialPaymentItem> partialCollect = new List<PartialPaymentItem>();

        public List<PartialPaymentItem> pubPartialCollect
        {
            get { return partialCollect; }
        }
        private List<BillItem> billCollect = new List<BillItem>();

        public List<BillItem> pubBillCollect
        {
            get { return billCollect; }
        }
        public void LoadJoinOldPartialPaymentsFromDb(int stdId)
        {
            paymentCollect = new List<PaymentItem>();
            partialCollect = new List<PartialPaymentItem>();
            billCollect = new List<BillItem>();
            paymentCollect.Clear();
            partialCollect.Clear();
            billCollect.Clear();

            using (var db = Connection.CreateConnection())
            {
                db.Open();

                var sql = "dbo.spJoinPartialPaymentsOld";
                var cmd = new SqlCommand(sql, db);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@StdId", stdId));
                var reader = cmd.ExecuteReader();

                if (!reader.HasRows)
                {
                    return;
                }

                while (reader.Read())
                {
                    var item = new PaymentItem();
                    var item2 = new PartialPaymentItem();
                    var item3 = new BillItem();

                    item.Payment_Id = Int32.Parse(reader["Payment_Id"].ToString());
                    item.Payment_PartPay_Id = Int32.Parse(reader["Payment_PartPay_Id"].ToString());
                    item.Payment_Bill_Id = Int32.Parse(reader["Payment_Bill_Id"].ToString());
                    item.Payment_Std_Id = Int32.Parse(reader["Payment_Std_Id"].ToString());
                    item.Payment_Number = Int32.Parse(reader["Payment_Number"].ToString());
                    item.Payment_Paid = Decimal.Parse(reader["Payment_Paid"].ToString());
                    item.Payment_DatePaid = reader["Payment_DatePaid"].ToString();
                    item.Payment_Deleted = reader["Payment_Deleted"].ToString();

                    item2.PartPay_Id = Int32.Parse(reader["PartPay_Id"].ToString());
                    item2.PartPay_Bill_Id = Int32.Parse(reader["PartPay_Bill_Id"].ToString());
                    item2.PartPay_Std_Id = Int32.Parse(reader["PartPay_Std_Id"].ToString());
                    item2.PartPay_Partition = reader["PartPay_Partition"].ToString();
                    item2.PartPay_Amount = Decimal.Parse(reader["PartPay_Amount"].ToString());
                    item2.PartPay_Balance = Decimal.Parse(reader["PartPay_Balance"].ToString());
                    item2.PartPay_DueDate = reader["PartPay_DueDate"].ToString();
                    item2.PartPay_DatePaid = reader["PartPay_DatePaid"].ToString();
                    item2.PartPay_PaymentMade = Decimal.Parse(reader["PartPay_PaymentMade"].ToString());
                    item2.PartPay_Status = reader["PartPay_Status"].ToString();
                    item2.PartPay_Deleted = reader["PartPay_Deleted"].ToString();

                    item3.Bill_Id = Int32.Parse(reader["Bill_Id"].ToString());

                    paymentCollect.Add(item);
                    partialCollect.Add(item2);
                    billCollect.Add(item3);
                }
                db.Close();
            }
        }
    }
}
