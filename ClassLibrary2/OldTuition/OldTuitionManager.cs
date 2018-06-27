using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentBillingLibrary
{
    public class OldTuitionManager
    {
        public void SaveOldTuition(OldTuitionItem oldItem)
        {
            using (var db = Connection.CreateConnection())
            {
                db.Open();

                var sql = "dbo.spInsertOldTuition";
                var cmd = new SqlCommand(sql, db);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@OldTuitionBillId", oldItem.OldTuition_Bill_Id));
                cmd.Parameters.Add(new SqlParameter("@OldTuitionStdId", oldItem.OldTuition_Std_Id));
                cmd.Parameters.Add(new SqlParameter("@OldTuitionDescription", oldItem.OldTuition_Description));
                cmd.Parameters.Add(new SqlParameter("@OldTuitionAmount", oldItem.OldTuition_Amount));
                cmd.Parameters.Add(new SqlParameter("@OldTuitionBalance", oldItem.OldTuition_Balance));
                cmd.Parameters.Add(new SqlParameter("@OldTuitionDatePaid", oldItem.OldTuition_DatePaid));
                cmd.Parameters.Add(new SqlParameter("@OldTuitionPaymentMade", oldItem.OldTuition_PayMade));
                cmd.Parameters.Add(new SqlParameter("@OldTuitionStatus", oldItem.OldTuition_Status));
                cmd.Parameters.Add(new SqlParameter("@OldTuitionDeleted", oldItem.OldTuition_Deleted));

                cmd.ExecuteNonQuery();

                db.Close();
            }
        }
        public void UpdateOldBalance(decimal oldBal, decimal oldPayMade, int oldId)
        {
            using (var db = Connection.CreateConnection())
            {
                db.Open();

                var sql = "dbo.spChangeOldBalance";
                var cmd = new SqlCommand(sql, db);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@NewBalance", oldBal));
                cmd.Parameters.Add(new SqlParameter("@NewPayMade", oldPayMade));
                cmd.Parameters.Add(new SqlParameter("@OldId", oldId));

                cmd.ExecuteNonQuery();

                db.Close();
            }
        }
        public void UpdateOldOtherBalance(decimal oldBal, decimal oldPayMade, int oldId)
        {
            using (var db = Connection.CreateConnection())
            {
                db.Open();

                var sql = "dbo.spChangeOldOtherBalance";
                var cmd = new SqlCommand(sql, db);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@NewBalance", oldBal));
                cmd.Parameters.Add(new SqlParameter("@NewPayMade", oldPayMade));
                cmd.Parameters.Add(new SqlParameter("@OldId", oldId));

                cmd.ExecuteNonQuery();

                db.Close();
            }
        }
        public void UpdatOld(OldTuitionItem oldItem)
        {
            using (var db = Connection.CreateConnection())
            {
                db.Open();

                var sql = "dbo.spUpdateOld";
                var cmd = new SqlCommand(sql, db);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Description", oldItem.OldTuition_Description));
                cmd.Parameters.Add(new SqlParameter("@Amount", oldItem.OldTuition_Amount));
                cmd.Parameters.Add(new SqlParameter("@Balance", oldItem.OldTuition_Balance));
                cmd.Parameters.Add(new SqlParameter("@Paymade", oldItem.OldTuition_PayMade));
                cmd.Parameters.Add(new SqlParameter("@DatePaid", oldItem.OldTuition_DatePaid));
                cmd.Parameters.Add(new SqlParameter("@Status", oldItem.OldTuition_Status));
                cmd.Parameters.Add(new SqlParameter("@OldId", oldItem.OldTuition_Id));

                cmd.ExecuteNonQuery();

                db.Close();
            }
        }
        public void DeleteOld(int OldId)
        {
            using (var db = Connection.CreateConnection())
            {
                db.Open();

                var sql = "dbo.spDeleteOld";
                var cmd = new SqlCommand(sql, db);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@OldId", OldId));

                cmd.ExecuteNonQuery();

                db.Close();
            }
        }
    }
}
