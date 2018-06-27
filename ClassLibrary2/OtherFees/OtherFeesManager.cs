using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentBillingLibrary
{
    public class OtherFeesManager
    {
        public void SaveOtherFees(List<OtherFeesItem> otherItem)
        {
            using (var db = Connection.CreateConnection())
            {
                db.Open();

                foreach (var popOther in otherItem)
                {
                    var sql = "dbo.spInsertOtherFees";
                    var cmd = new SqlCommand(sql, db);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@OtherFeesBillId", popOther.OtherFees_Bill_Id));
                    cmd.Parameters.Add(new SqlParameter("@OtherFeesStd", popOther.OtherFees_Std_Id));
                    cmd.Parameters.Add(new SqlParameter("@OtherFeesDescription", popOther.OtherFees_Description));
                    cmd.Parameters.Add(new SqlParameter("@OtherFeesAmount", popOther.OtherFees_Amount));
                    cmd.Parameters.Add(new SqlParameter("@OtherFeesBalance", popOther.OtherFees_Balance));
                    cmd.Parameters.Add(new SqlParameter("@OtherFeesDueDate", popOther.OtherFees_DueDate));
                    cmd.Parameters.Add(new SqlParameter("@OtherFeesDatePaid", popOther.OtherFees_DatePaid));
                    cmd.Parameters.Add(new SqlParameter("@OtherFeesPaymentMade", popOther.OtherFees_PaymentMade));
                    cmd.Parameters.Add(new SqlParameter("@OtherFeesCutOffDate", popOther.OtherFees_CutOffDate));
                    cmd.Parameters.Add(new SqlParameter("@OtherFeesStatus", popOther.OtherFees_Status));
                    cmd.Parameters.Add(new SqlParameter("@OtherFeesIsOld", popOther.OtherFees_IsOld));
                    cmd.Parameters.Add(new SqlParameter("@OtherFeesDeleted", popOther.OtherFees_Deleted));

                    cmd.ExecuteNonQuery();
                }

                db.Close();
            }
        }
        public void UpdateOther(OtherFeesItem otherItem)
        {
            using (var db = Connection.CreateConnection())
            {
                db.Open();

                var sql = "dbo.spUpdateOther";
                var cmd = new SqlCommand(sql, db);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Description", otherItem.OtherFees_Description));
                cmd.Parameters.Add(new SqlParameter("@Amount", otherItem.OtherFees_Amount));
                cmd.Parameters.Add(new SqlParameter("@Balance", otherItem.OtherFees_Balance));
                cmd.Parameters.Add(new SqlParameter("@Paymade", otherItem.OtherFees_PaymentMade));
                cmd.Parameters.Add(new SqlParameter("@DueDate", otherItem.OtherFees_DueDate));
                cmd.Parameters.Add(new SqlParameter("@DatePaid", otherItem.OtherFees_DatePaid));
                cmd.Parameters.Add(new SqlParameter("@CutOffDate", otherItem.OtherFees_CutOffDate));
                cmd.Parameters.Add(new SqlParameter("@Status", otherItem.OtherFees_Status));
                cmd.Parameters.Add(new SqlParameter("@OtherId", otherItem.OtherFees_Id));

                cmd.ExecuteNonQuery();

                db.Close();
            }
        }
        public void UpdateOldOther(OtherFeesItem otherItem)
        {
            using (var db = Connection.CreateConnection())
            {
                db.Open();

                var sql = "dbo.spUpdateOldOther";
                var cmd = new SqlCommand(sql, db);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Description", otherItem.OtherFees_Description));
                cmd.Parameters.Add(new SqlParameter("@Amount", otherItem.OtherFees_Amount));
                cmd.Parameters.Add(new SqlParameter("@Balance", otherItem.OtherFees_Balance));
                cmd.Parameters.Add(new SqlParameter("@Paymade", otherItem.OtherFees_PaymentMade));
                cmd.Parameters.Add(new SqlParameter("@DatePaid", otherItem.OtherFees_DatePaid));
                cmd.Parameters.Add(new SqlParameter("@Status", otherItem.OtherFees_Status));
                cmd.Parameters.Add(new SqlParameter("@OtherId", otherItem.OtherFees_Id));

                cmd.ExecuteNonQuery();

                db.Close();
            }
        }
        public void DeleteOther(int OtherId)
        {
            using (var db = Connection.CreateConnection())
            {
                db.Open();

                var sql = "dbo.spDeleteOther";
                var cmd = new SqlCommand(sql, db);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@OtherId", OtherId));

                cmd.ExecuteNonQuery();

                db.Close();
            }
        }
        public void SetOtherToOld(int otherId)
        {
            using (var db = Connection.CreateConnection())
            {
                db.Open();

                var sql = "dbo.spSetOldOther";
                var cmd = new SqlCommand(sql, db);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@OtherId", otherId));

                cmd.ExecuteNonQuery();

                db.Close();
            }
        }
    }
}
