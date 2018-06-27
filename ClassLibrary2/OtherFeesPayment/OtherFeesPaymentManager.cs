using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentBillingLibrary
{
    public class OtherFeesPaymentManager
    {
        public void SaveOtherPay(OtherFeesPaymentItem otherPayItem)
        {
            using (var db = Connection.CreateConnection())
            {
                db.Open();

                var sql = "dbo.spInsertOtherPayments";
                var cmd = new SqlCommand(sql, db);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@OtherId", otherPayItem.OtherPay_OtherFees_Id));
                cmd.Parameters.Add(new SqlParameter("@BillId", otherPayItem.OtherPay_Bill_Id));
                cmd.Parameters.Add(new SqlParameter("@StdId", otherPayItem.OtherPay_Std_Id));
                cmd.Parameters.Add(new SqlParameter("@PayNum", otherPayItem.OtherPay_Number));
                cmd.Parameters.Add(new SqlParameter("@AmountPay", otherPayItem.OtherPay_Paid));
                cmd.Parameters.Add(new SqlParameter("@DatePaid", otherPayItem.OtherPay_DatePaid));
                cmd.Parameters.Add(new SqlParameter("@IsOld", otherPayItem.OtherPay_IsOld));
                cmd.Parameters.Add(new SqlParameter("@Deleted", otherPayItem.OtherPay_Deleted));

                cmd.ExecuteNonQuery();

                db.Close();
            }
        }
        public void UpdateOtherPayment(OtherFeesPaymentItem otherItem)
        {
            using (var db = Connection.CreateConnection())
            {
                db.Open();

                var sql = "dbo.spUpdateOtherPayments";
                var cmd = new SqlCommand(sql, db);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@PayNo", otherItem.OtherPay_Number));
                cmd.Parameters.Add(new SqlParameter("@Amount", otherItem.OtherPay_Paid));
                cmd.Parameters.Add(new SqlParameter("@DatePaid", otherItem.OtherPay_DatePaid));
                cmd.Parameters.Add(new SqlParameter("@OtherPayId", otherItem.OtherPay_Id));

                cmd.ExecuteNonQuery();

                db.Close();
            }
        }
        public void UpdateBalance(decimal otherBal, decimal otherPayMade, int otherId, decimal billBal, decimal billPayMade, int billId)
        {
            using (var db = Connection.CreateConnection())
            {
                db.Open();

                var sql = "dbo.spChangeOtherBalance";
                var cmd = new SqlCommand(sql, db);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@NewBalance", otherBal));
                cmd.Parameters.Add(new SqlParameter("@NewPayMade", otherPayMade));
                cmd.Parameters.Add(new SqlParameter("@OtherId", otherId));
                cmd.Parameters.Add(new SqlParameter("@NewBillBalance", billBal));
                cmd.Parameters.Add(new SqlParameter("@NewBillPayMade", billPayMade));
                cmd.Parameters.Add(new SqlParameter("@BillId", billId));

                cmd.ExecuteNonQuery();

                db.Close();
            }
        }
        public void DeleteOtherPayments(int OtherPayId)
        {
            using (var db = Connection.CreateConnection())
            {
                db.Open();

                var sql = "dbo.spDeleteOtherPayments";
                var cmd = new SqlCommand(sql, db);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@OtherPayId", OtherPayId));

                cmd.ExecuteNonQuery();

                db.Close();
            }
        }
    }
}
