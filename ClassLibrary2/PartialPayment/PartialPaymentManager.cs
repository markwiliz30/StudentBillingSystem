using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentBillingLibrary
{
    public class PartialPaymentManager
    {
        public void SavePartialPayment(List<PartialPaymentItem> partItem)
        {
            using (var db = Connection.CreateConnection())
            {
                db.Open();

                foreach (var popPartPay in partItem)
                {
                    var sql = "dbo.spInsertPartialPayments";
                    var cmd = new SqlCommand(sql, db);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PartPayBillId", popPartPay.PartPay_Bill_Id));
                    cmd.Parameters.Add(new SqlParameter("@PartPayStdId", popPartPay.PartPay_Std_Id));
                    cmd.Parameters.Add(new SqlParameter("@PartPayPartition", popPartPay.PartPay_Partition));
                    cmd.Parameters.Add(new SqlParameter("@PartPayAmount", popPartPay.PartPay_Amount));
                    cmd.Parameters.Add(new SqlParameter("@PartPayBalance", popPartPay.PartPay_Balance));
                    cmd.Parameters.Add(new SqlParameter("@PartPayDueDate", popPartPay.PartPay_DueDate));
                    cmd.Parameters.Add(new SqlParameter("@PartPayDatePaid", popPartPay.PartPay_DatePaid));
                    cmd.Parameters.Add(new SqlParameter("@PartPayPaymentMade", popPartPay.PartPay_PaymentMade));
                    cmd.Parameters.Add(new SqlParameter("@PartPayStatus", popPartPay.PartPay_Status));
                    cmd.Parameters.Add(new SqlParameter("@PartPayDeleted", popPartPay.PartPay_Deleted));

                    cmd.ExecuteNonQuery();
                }

                db.Close();
            }
        }
        public void UpdatePartialPayments(PartialPaymentItem partItem)
        {
            using (var db = Connection.CreateConnection())
            {
                db.Open();

                var sql = "dbo.spUpdatePartPay";
                var cmd = new SqlCommand(sql, db);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Partition", partItem.PartPay_Partition));
                cmd.Parameters.Add(new SqlParameter("@Amount", partItem.PartPay_Amount));
                cmd.Parameters.Add(new SqlParameter("@Balance", partItem.PartPay_Balance));
                cmd.Parameters.Add(new SqlParameter("@Paymade", partItem.PartPay_PaymentMade));
                cmd.Parameters.Add(new SqlParameter("@DueDate", partItem.PartPay_DueDate));
                cmd.Parameters.Add(new SqlParameter("@DatePaid", partItem.PartPay_DatePaid));
                cmd.Parameters.Add(new SqlParameter("@Status", partItem.PartPay_Status));
                cmd.Parameters.Add(new SqlParameter("@PartId", partItem.PartPay_Id));

                cmd.ExecuteNonQuery();

                db.Close();
            }
        }
        public void DeletePartition(int partId)
        {
            using (var db = Connection.CreateConnection())
            {
                db.Open();

                var sql = "dbo.spDeleteTuitionPart";
                var cmd = new SqlCommand(sql, db);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@PartId", partId));

                cmd.ExecuteNonQuery();

                db.Close();
            }
        }
    }
}
