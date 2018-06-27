using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentBillingLibrary
{
    public class OtherFeesPaymentCollection
    {
        private List<OtherFeesPaymentItem> otherPayCollect = new List<OtherFeesPaymentItem>();
        public List<OtherFeesPaymentItem> pubOtherPayCollect
        {
            get { return otherPayCollect; }
        }
        public void LoadOtherPayWithOtherIdFromDb(int otherId)
        {
            otherPayCollect = new List<OtherFeesPaymentItem>();
            otherPayCollect.Clear();

            using (var db = Connection.CreateConnection())
            {
                db.Open();

                var sql = "dbo.spLoadOtherFeesPayWithOtherId";
                var cmd = new SqlCommand(sql, db);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@OtherId", otherId));
                var reader = cmd.ExecuteReader();

                if (!reader.HasRows)
                {
                    return;
                }

                while (reader.Read())
                {
                    var item = new OtherFeesPaymentItem();

                    item.OtherPay_Id = Int32.Parse(reader["OtherPay_Id"].ToString());
                    item.OtherPay_OtherFees_Id = Int32.Parse(reader["OtherPay_OtherFees_Id"].ToString());
                    item.OtherPay_Bill_Id = Int32.Parse(reader["OtherPay_Bill_Id"].ToString());
                    item.OtherPay_Std_Id = Int32.Parse(reader["OtherPay_Std_Id"].ToString());
                    item.OtherPay_Number = Int32.Parse(reader["OtherPay_Number"].ToString());
                    item.OtherPay_Paid = Decimal.Parse(reader["OtherPay_Paid"].ToString());
                    item.OtherPay_DatePaid = reader["OtherPay_DatePaid"].ToString();
                    item.OtherPay_Deleted = reader["OtherPay_Deleted"].ToString();

                    otherPayCollect.Add(item);
                }
                db.Close();
            }
        }
        public void LoadOtherPayWithOtherIdOldFromDb(int oldId)
        {
            otherPayCollect = new List<OtherFeesPaymentItem>();
            otherPayCollect.Clear();

            using (var db = Connection.CreateConnection())
            {
                db.Open();

                var sql = "dbo.spLoadOtherFeesPayWithOldId";
                var cmd = new SqlCommand(sql, db);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@OldId", oldId));
                var reader = cmd.ExecuteReader();

                if (!reader.HasRows)
                {
                    return;
                }

                while (reader.Read())
                {
                    var item = new OtherFeesPaymentItem();

                    item.OtherPay_Id = Int32.Parse(reader["OtherPay_Id"].ToString());
                    item.OtherPay_OtherFees_Id = Int32.Parse(reader["OtherPay_OtherFees_Id"].ToString());
                    item.OtherPay_Bill_Id = Int32.Parse(reader["OtherPay_Bill_Id"].ToString());
                    item.OtherPay_Std_Id = Int32.Parse(reader["OtherPay_Std_Id"].ToString());
                    item.OtherPay_Number = Int32.Parse(reader["OtherPay_Number"].ToString());
                    item.OtherPay_Paid = Decimal.Parse(reader["OtherPay_Paid"].ToString());
                    item.OtherPay_DatePaid = reader["OtherPay_DatePaid"].ToString();
                    item.OtherPay_Deleted = reader["OtherPay_Deleted"].ToString();

                    otherPayCollect.Add(item);
                }
                db.Close();
            }
        }
    }
}
