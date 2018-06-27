using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentBillingLibrary
{
    public class OldTuitionCollection
    {
        private List<OldTuitionItem> oldCollect = new List<OldTuitionItem>();
        public List<OldTuitionItem> pubOldCollect
        {
            get { return oldCollect; }
        }
        public void LoadOldTuitionWithStdIdFromDb(int stdId)
        {
            oldCollect = new List<OldTuitionItem>();
            oldCollect.Clear();

            using (var db = Connection.CreateConnection())
            {
                db.Open();

                var sql = "dbo.spLoadOldTuitionWithStdId";
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
                    var item = new OldTuitionItem();

                    item.OldTuition_Id = Int32.Parse(reader["OldTuition_Id"].ToString());
                    item.OldTuition_Bill_Id = Int32.Parse(reader["OldTuition_Bill_Id"].ToString());
                    item.OldTuition_Std_Id = Int32.Parse(reader["OldTuition_Std_Id"].ToString());
                    item.OldTuition_Description = reader["OldTuition_Description"].ToString();
                    item.OldTuition_Amount = Decimal.Parse(reader["OldTuition_Amount"].ToString());
                    item.OldTuition_Balance = Decimal.Parse(reader["OldTuition_Balance"].ToString());
                    item.OldTuition_DatePaid = reader["OldTuition_DatePaid"].ToString();
                    item.OldTuition_PayMade = Decimal.Parse(reader["OldTuition_PayMade"].ToString());
                    item.OldTuition_Status = reader["OldTuition_Status"].ToString();
                    item.OldTuition_Deleted = reader["OldTuition_Deleted"].ToString();

                    oldCollect.Add(item);
                }
                db.Close();
            }
        }
        public void LoadOldTuitionFromDb()
        {
            oldCollect = new List<OldTuitionItem>();
            oldCollect.Clear();

            using (var db = Connection.CreateConnection())
            {
                db.Open();

                var sql = "dbo.spLoadOldTuition";
                var cmd = new SqlCommand(sql, db);
                cmd.CommandType = CommandType.StoredProcedure;
                var reader = cmd.ExecuteReader();

                if (!reader.HasRows)
                {
                    return;
                }

                while (reader.Read())
                {
                    var item = new OldTuitionItem();

                    item.OldTuition_Id = Int32.Parse(reader["OldTuition_Id"].ToString());
                    item.OldTuition_Bill_Id = Int32.Parse(reader["OldTuition_Bill_Id"].ToString());
                    item.OldTuition_Std_Id = Int32.Parse(reader["OldTuition_Std_Id"].ToString());
                    item.OldTuition_Description = reader["OldTuition_Description"].ToString();
                    item.OldTuition_Amount = Decimal.Parse(reader["OldTuition_Amount"].ToString());
                    item.OldTuition_Balance = Decimal.Parse(reader["OldTuition_Balance"].ToString());
                    item.OldTuition_DatePaid = reader["OldTuition_DatePaid"].ToString();
                    item.OldTuition_PayMade = Decimal.Parse(reader["OldTuition_PayMade"].ToString());
                    item.OldTuition_Status = reader["OldTuition_Status"].ToString();
                    item.OldTuition_Deleted = reader["OldTuition_Deleted"].ToString();

                    oldCollect.Add(item);
                }
                db.Close();
            }
        }
    }
}
