using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentBillingLibrary
{
    public class TuitionPayments
    {
        private List<TuitionPaymentItem> paymentCollect = new List<TuitionPaymentItem>();

        public List<TuitionPaymentItem> pubPaymentCollect
        {
            get { return paymentCollect; }
        }
        public void LoadJoinPartialPaymentsFromDb(int stdId)
        {
            paymentCollect = new List<TuitionPaymentItem>();
            paymentCollect.Clear();

            using (var db = Connection.CreateConnection())
            {
                db.Open();

                var sql = "dbo.spJoinPartialPayments";
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
                    var item = new TuitionPaymentItem();

                    item.Payment_Number = Int32.Parse(reader["Payment_Number"].ToString());
                    item.Payment_Paid = Decimal.Parse(reader["Payment_Paid"].ToString());
                    item.Payment_DatePaid = reader["Payment_DatePaid"].ToString();
                    item.PartPay_Id = Int32.Parse(reader["PartPay_Id"].ToString());
                    item.PartPay_Partition = reader["PartPay_Partition"].ToString();
                    item.PartPay_Amount = Decimal.Parse(reader["PartPay_Amount"].ToString());
                    item.PartPay_Balance = Decimal.Parse(reader["PartPay_Balance"].ToString());
                    item.PartPay_DueDate = reader["PartPay_DueDate"].ToString();
                    item.PartPay_PaymentMade = Decimal.Parse(reader["PartPay_PaymentMade"].ToString());
                    item.PartPay_Status = reader["PartPay_Status"].ToString();

                    paymentCollect.Add(item);
                }
                db.Close();
            }
        }
    }
}
