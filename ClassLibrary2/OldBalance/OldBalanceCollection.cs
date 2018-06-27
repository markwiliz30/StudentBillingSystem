using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentBillingLibrary
{
    public class OldBalanceCollection
    {
        private List<OldBalanceItem> oldBalanceCollect = new List<OldBalanceItem>();

        public List<OldBalanceItem> pubOldBalanceCollect
        {
            get { return oldBalanceCollect; }
        }
        public void LoadOldBalanceFromDb()
        {
            oldBalanceCollect = new List<OldBalanceItem>();
            oldBalanceCollect.Clear();

            using (var db = Connection.CreateConnection())
            {
                db.Open();

                var sql = "dbo.spLoadOldBalance";
                var cmd = new SqlCommand(sql, db);
                var reader = cmd.ExecuteReader();

                if (!reader.HasRows)
                {
                    return;
                }

                while (reader.Read())
                {
                    var item = new OldBalanceItem();

                    item.OldFees_Id = Int32.Parse(reader["OldFees_Id"].ToString());
                    item.OldFees_Std_Id = Int32.Parse(reader["OldFees_Std_Id"].ToString());
                    item.OldFees_Bill_Id = Int32.Parse(reader["OldFees_Bill_Id"].ToString());
                    item.OldFees_Description = reader["OldFees_Description"].ToString();
                    item.OldFees_PaymentNumber = Int32.Parse(reader["OldFees_PaymentNumber"].ToString());
                    item.OldFees_Amount = Decimal.Parse(reader["OldFees_Amount"].ToString());
                    item.OldFees_Payment = Decimal.Parse(reader["OldFees_Payment"].ToString());
                    item.OldFees_DatePaid = reader["OldFees_DatePaid"].ToString();
                    item.OldFees_PaymentMade = Decimal.Parse(reader["OldFees_PaymentMade"].ToString());
                    item.OldFees_Balance = Decimal.Parse(reader["OldFees_Balance"].ToString());
                    item.OldFees_Status = Boolean.Parse(reader["OldFees_Status"].ToString());
                    item.OldFees_Deleted = reader["OldFees_Deleted"].ToString();

                    oldBalanceCollect.Add(item);
                }
                db.Close();
            }
        }
        public void LoadOldBalanceWithStdIdFromDb(int stdId)
        {
            oldBalanceCollect = new List<OldBalanceItem>();
            oldBalanceCollect.Clear();

            using (var db = Connection.CreateConnection())
            {
                db.Open();

                var sql = "dbo.spLoadOldBalanceWithStdId";
                var cmd = new SqlCommand(sql, db);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("StdId", stdId));
                var reader = cmd.ExecuteReader();

                if (!reader.HasRows)
                {
                    return;
                }

                while (reader.Read())
                {
                    var item = new OldBalanceItem();

                    item.OldFees_Id = Int32.Parse(reader["OldFees_Id"].ToString());
                    item.OldFees_Std_Id = Int32.Parse(reader["OldFees_Std_Id"].ToString());
                    item.OldFees_Bill_Id = Int32.Parse(reader["OldFees_Bill_Id"].ToString());
                    item.OldFees_Description = reader["OldFees_Description"].ToString();
                    item.OldFees_PaymentNumber = Int32.Parse(reader["OldFees_PaymentNumber"].ToString());
                    item.OldFees_Amount = Decimal.Parse(reader["OldFees_Amount"].ToString());
                    item.OldFees_Payment = Decimal.Parse(reader["OldFees_Payment"].ToString());
                    item.OldFees_DatePaid = reader["OldFees_DatePaid"].ToString();
                    item.OldFees_PaymentMade = Decimal.Parse(reader["OldFees_PaymentMade"].ToString());
                    item.OldFees_Balance = Decimal.Parse(reader["OldFees_Balance"].ToString());
                    item.OldFees_Status = Boolean.Parse(reader["OldFees_Status"].ToString());
                    item.OldFees_Deleted = reader["OldFees_Deleted"].ToString();

                    oldBalanceCollect.Add(item);
                }
                db.Close();
            }
        }
        public void GetOldBalanceDescriptionFromDb()
        {
            //otherFeesCollect = new List<OtherFeesItem>();
            oldBalanceCollect.Clear();

            using (var db = Connection.CreateConnection())
            {
                db.Open();

                var sql = "dbo.spGetOldBalanceByDescription";
                var cmd = new SqlCommand(sql, db);
                var reader = cmd.ExecuteReader();

                if (!reader.HasRows)
                {
                    return;
                }

                while (reader.Read())
                {
                    var item = new OldBalanceItem();

                    item.OldFees_Description = reader["OldFees_Description"].ToString();
                    if (oldBalanceCollect.Count == 0)
                    {
                        oldBalanceCollect.Add(item);
                    }
                    else if (oldBalanceCollect.All(x => (x.OldFees_Description != item.OldFees_Description)))
                    {
                        oldBalanceCollect.Add(item);
                    }
                }
                db.Close();
            }
        }
        public void GetOldBalanceWithStdIdDescriptionFromDb(int stdId)
        {
            //otherFeesCollect = new List<OtherFeesItem>();
            oldBalanceCollect.Clear();

            using (var db = Connection.CreateConnection())
            {
                db.Open();

                var sql = "dbo.spGetOldBalanceWithStdIdByDescription";
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
                    var item = new OldBalanceItem();

                    item.OldFees_Description = reader["OldFees_Description"].ToString();
                    if (oldBalanceCollect.Count == 0)
                    {
                        oldBalanceCollect.Add(item);
                    }
                    else if (oldBalanceCollect.All(x => (x.OldFees_Description != item.OldFees_Description)))
                    {
                        oldBalanceCollect.Add(item);
                    }
                }
                db.Close();
            }
        }
        public void LoadSelectedOldBalanceFromDb(string selDescription)
        {
            oldBalanceCollect = new List<OldBalanceItem>();
            oldBalanceCollect.Clear();

            using (var db = Connection.CreateConnection())
            {
                db.Open();

                var sql = "dbo.spGetSelectedOldBalanceDescription";
                var cmd = new SqlCommand(sql, db);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Description", selDescription));
                var reader = cmd.ExecuteReader();

                if (!reader.HasRows)
                {
                    return;
                }

                while (reader.Read())
                {
                    var item = new OldBalanceItem();

                    item.OldFees_Id = Int32.Parse(reader["OldFees_Id"].ToString());
                    item.OldFees_Bill_Id = Int32.Parse(reader["OldFees_Bill_Id"].ToString());
                    item.OldFees_Description = reader["OldFees_Description"].ToString();
                    item.OldFees_PaymentNumber = Int32.Parse(reader["OldFees_PaymentNumber"].ToString());
                    item.OldFees_Amount = Decimal.Parse(reader["OldFees_Amount"].ToString());
                    item.OldFees_Payment = Decimal.Parse(reader["OldFees_Payment"].ToString());
                    item.OldFees_DatePaid = reader["OldFees_DatePaid"].ToString();
                    item.OldFees_Balance = Decimal.Parse(reader["OldFees_Balance"].ToString());
                    item.OldFees_Status = Boolean.Parse(reader["OldFees_Status"].ToString());
                    item.OldFees_PaymentMade = Decimal.Parse(reader["OldFees_PaymentMade"].ToString());
                    item.OldFees_Deleted = reader["OldFees_Deleted"].ToString();

                    oldBalanceCollect.Add(item);
                }
                db.Close();
            }
        }
        public void LoadSelectedOldBalanceWithStdIdFromDb(string selDescription, int stdId)
        {
            oldBalanceCollect = new List<OldBalanceItem>();
            oldBalanceCollect.Clear();

            using (var db = Connection.CreateConnection())
            {
                db.Open();

                var sql = "dbo.spGetSelectedOldBalanceWithStdIdDescription";
                var cmd = new SqlCommand(sql, db);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Description", selDescription));
                cmd.Parameters.Add(new SqlParameter("@StdId", stdId));
                var reader = cmd.ExecuteReader();

                if (!reader.HasRows)
                {
                    return;
                }

                while (reader.Read())
                {
                    var item = new OldBalanceItem();

                    item.OldFees_Id = Int32.Parse(reader["OldFees_Id"].ToString());
                    item.OldFees_Bill_Id = Int32.Parse(reader["OldFees_Bill_Id"].ToString());
                    item.OldFees_Description = reader["OldFees_Description"].ToString();
                    item.OldFees_PaymentNumber = Int32.Parse(reader["OldFees_PaymentNumber"].ToString());
                    item.OldFees_Amount = Decimal.Parse(reader["OldFees_Amount"].ToString());
                    item.OldFees_Payment = Decimal.Parse(reader["OldFees_Payment"].ToString());
                    item.OldFees_DatePaid = reader["OldFees_DatePaid"].ToString();
                    item.OldFees_Balance = Decimal.Parse(reader["OldFees_Balance"].ToString());
                    item.OldFees_Status = Boolean.Parse(reader["OldFees_Status"].ToString());
                    item.OldFees_PaymentMade = Decimal.Parse(reader["OldFees_PaymentMade"].ToString());
                    item.OldFees_Deleted = reader["OldFees_Deleted"].ToString();

                    oldBalanceCollect.Add(item);
                }
                db.Close();
            }
        }
    }
}
