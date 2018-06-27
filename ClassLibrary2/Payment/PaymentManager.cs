using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentBillingLibrary
{
    public class PaymentManager
    {
        public void SavePayment(PaymentItem payItem)
        {
            using (var db = Connection.CreateConnection())
            {
                db.Open();

                var sql = "dbo.spInsertPayment";
                var cmd = new SqlCommand(sql, db);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@PartId", payItem.Payment_PartPay_Id));
                cmd.Parameters.Add(new SqlParameter("@BillId", payItem.Payment_Bill_Id));
                cmd.Parameters.Add(new SqlParameter("@StdId", payItem.Payment_Std_Id));
                cmd.Parameters.Add(new SqlParameter("@PayNum", payItem.Payment_Number));
                cmd.Parameters.Add(new SqlParameter("@AmountPay", payItem.Payment_Paid));
                cmd.Parameters.Add(new SqlParameter("@DatePaid", payItem.Payment_DatePaid));
                cmd.Parameters.Add(new SqlParameter("@IsOld", payItem.Payment_IsOld));
                cmd.Parameters.Add(new SqlParameter("@Deleted", payItem.Payment_Deleted));

                cmd.ExecuteNonQuery();

                db.Close();
            }
        }
        public void UpdatePayment(PaymentItem payItem)
        {
            using (var db = Connection.CreateConnection())
            {
                db.Open();

                var sql = "dbo.spUpdatePayments";
                var cmd = new SqlCommand(sql, db);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@PayNo", payItem.Payment_Number));
                cmd.Parameters.Add(new SqlParameter("@Amount", payItem.Payment_Paid));
                cmd.Parameters.Add(new SqlParameter("@DatePaid", payItem.Payment_DatePaid));
                cmd.Parameters.Add(new SqlParameter("@PayId", payItem.Payment_Id));

                cmd.ExecuteNonQuery();

                db.Close();
            }
        }
        public void UpdateBalance(decimal partBal, decimal partpayMade, int partId, decimal billBal, decimal billPayMade, int billId)
        {
            using (var db = Connection.CreateConnection())
            {
                db.Open();

                var sql = "dbo.spChangeTuitionBalance";
                var cmd = new SqlCommand(sql, db);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@NewBalance", partBal));
                cmd.Parameters.Add(new SqlParameter("@NewPayMade", partpayMade));
                cmd.Parameters.Add(new SqlParameter("@PartId", partId));
                cmd.Parameters.Add(new SqlParameter("@NewBillBalance", billBal));
                cmd.Parameters.Add(new SqlParameter("@NewBillPayMade", billPayMade));
                cmd.Parameters.Add(new SqlParameter("@BillId", billId));

                cmd.ExecuteNonQuery();

                db.Close();
            }
        }
        public void DeletePayment(int payId)
        {
            using (var db = Connection.CreateConnection())
            {
                db.Open();

                var sql = "dbo.spDeleteTuitionPayment";
                var cmd = new SqlCommand(sql, db);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@PayId", payId));

                cmd.ExecuteNonQuery();

                db.Close();
            }
        }
    }
}
