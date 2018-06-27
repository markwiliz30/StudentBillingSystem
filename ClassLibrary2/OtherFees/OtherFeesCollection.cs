using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using Dapper;

namespace StudentBillingLibrary
{
    public class OtherFeesCollection
    {
        private List<OtherFeesItem> otherFeesCollect = new List<OtherFeesItem>();
        public List<OtherFeesItem> pubOtherFeesCollect
        {
            get { return otherFeesCollect; }
        }
        public void LoadOtherFeesFromDb()
        {
            otherFeesCollect = new List<OtherFeesItem>();
            otherFeesCollect.Clear();

            using (var db = Connection.CreateConnection())
            {
                db.Open();

                var sql = "dbo.spLoadOtherFees";
                var cmd = new SqlCommand(sql, db);
                var reader = cmd.ExecuteReader();

                if (!reader.HasRows)
                {
                    return;
                }

                while (reader.Read())
                {
                    var item = new OtherFeesItem();

                    item.OtherFees_Id = Int32.Parse(reader["OtherFees_Id"].ToString());
                    item.OtherFees_Bill_Id = Int32.Parse(reader["OtherFees_Bill_Id"].ToString());
                    item.OtherFees_Std_Id = Int32.Parse(reader["OtherFees_Std_Id"].ToString());
                    item.OtherFees_Description = reader["OtherFees_Description"].ToString();
                    item.OtherFees_Amount = Decimal.Parse(reader["OtherFees_Amount"].ToString());
                    item.OtherFees_DatePaid = reader["OtherFees_DatePaid"].ToString();
                    item.OtherFees_Balance = Decimal.Parse(reader["OtherFees_Balance"].ToString());
                    item.OtherFees_Status = reader["OtherFees_Status"].ToString();
                    item.OtherFees_PaymentMade = Decimal.Parse(reader["OtherFees_PaymentMade"].ToString());
                    item.OtherFees_DueDate = reader["OtherFees_DueDate"].ToString();
                    item.OtherFees_CutOffDate = reader["OtherFees_CutOffDate"].ToString();
                    item.OtherFees_IsOld = reader["OtherFees_IsOld"].ToString();
                    item.OtherFees_Deleted = reader["OtherFees_Deleted"].ToString();

                    otherFeesCollect.Add(item);
                }
                db.Close();
            }
        }
        public void LoadOtherFeesWithBillIdFromDb(int BillId)
        {
            otherFeesCollect = new List<OtherFeesItem>();
            otherFeesCollect.Clear();

            using (var db = Connection.CreateConnection())
            {
                db.Open();

                var sql = "dbo.spLoadOtherFeesWithBillId";
                var cmd = new SqlCommand(sql, db);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@BillId", BillId));
                var reader = cmd.ExecuteReader();

                if (!reader.HasRows)
                {
                    return;
                }

                while (reader.Read())
                {
                    var item = new OtherFeesItem();

                    item.OtherFees_Id = Int32.Parse(reader["OtherFees_Id"].ToString());
                    item.OtherFees_Bill_Id = Int32.Parse(reader["OtherFees_Bill_Id"].ToString());
                    item.OtherFees_Std_Id = Int32.Parse(reader["OtherFees_Std_Id"].ToString());
                    item.OtherFees_Description = reader["OtherFees_Description"].ToString();
                    item.OtherFees_Amount = Decimal.Parse(reader["OtherFees_Amount"].ToString());
                    item.OtherFees_DatePaid = reader["OtherFees_DatePaid"].ToString();
                    item.OtherFees_Balance = Decimal.Parse(reader["OtherFees_Balance"].ToString());
                    item.OtherFees_Status = reader["OtherFees_Status"].ToString();
                    item.OtherFees_PaymentMade = Decimal.Parse(reader["OtherFees_PaymentMade"].ToString());
                    item.OtherFees_DueDate = reader["OtherFees_DueDate"].ToString();
                    item.OtherFees_CutOffDate = reader["OtherFees_CutOffDate"].ToString();
                    item.OtherFees_IsOld = reader["OtherFees_IsOld"].ToString();
                    item.OtherFees_Deleted = reader["OtherFees_Deleted"].ToString();

                    otherFeesCollect.Add(item);
                }
                db.Close();
            }
        }
        public void LoadOldOtherFeesWithStdIdFromDb(int StdId)
        {
            otherFeesCollect = new List<OtherFeesItem>();
            otherFeesCollect.Clear();

            using (var db = Connection.CreateConnection())
            {
                db.Open();

                var sql = "dbo.spLoadOldOtherFeesWithStdId";
                var cmd = new SqlCommand(sql, db);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@StdId", StdId));
                var reader = cmd.ExecuteReader();

                if (!reader.HasRows)
                {
                    return;
                }

                while (reader.Read())
                {
                    var item = new OtherFeesItem();

                    item.OtherFees_Id = Int32.Parse(reader["OtherFees_Id"].ToString());
                    item.OtherFees_Bill_Id = Int32.Parse(reader["OtherFees_Bill_Id"].ToString());
                    item.OtherFees_Std_Id = Int32.Parse(reader["OtherFees_Std_Id"].ToString());
                    item.OtherFees_Description = reader["OtherFees_Description"].ToString();
                    item.OtherFees_Amount = Decimal.Parse(reader["OtherFees_Amount"].ToString());
                    item.OtherFees_DatePaid = reader["OtherFees_DatePaid"].ToString();
                    item.OtherFees_Balance = Decimal.Parse(reader["OtherFees_Balance"].ToString());
                    item.OtherFees_Status = reader["OtherFees_Status"].ToString();
                    item.OtherFees_PaymentMade = Decimal.Parse(reader["OtherFees_PaymentMade"].ToString());
                    item.OtherFees_DueDate = reader["OtherFees_DueDate"].ToString();
                    item.OtherFees_CutOffDate = reader["OtherFees_CutOffDate"].ToString();
                    item.OtherFees_IsOld = reader["OtherFees_IsOld"].ToString();
                    item.OtherFees_Deleted = reader["OtherFees_Deleted"].ToString();

                    otherFeesCollect.Add(item);
                }
                db.Close();
            }
        }
        public void LoadOtherFeesWithStdIdFromDb(int StdId)
        {
            otherFeesCollect = new List<OtherFeesItem>();
            otherFeesCollect.Clear();

            using (var db = Connection.CreateConnection())
            {
                db.Open();

                var sql = "dbo.spLoadOtherFeesWithStdId";
                var cmd = new SqlCommand(sql, db);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@StdId", StdId));
                var reader = cmd.ExecuteReader();

                if (!reader.HasRows)
                {
                    return;
                }

                while (reader.Read())
                {
                    var item = new OtherFeesItem();

                    item.OtherFees_Id = Int32.Parse(reader["OtherFees_Id"].ToString());
                    item.OtherFees_Bill_Id = Int32.Parse(reader["OtherFees_Bill_Id"].ToString());
                    item.OtherFees_Std_Id = Int32.Parse(reader["OtherFees_Std_Id"].ToString());
                    item.OtherFees_Description = reader["OtherFees_Description"].ToString();
                    item.OtherFees_Amount = Decimal.Parse(reader["OtherFees_Amount"].ToString());
                    item.OtherFees_DatePaid = reader["OtherFees_DatePaid"].ToString();
                    item.OtherFees_Balance = Decimal.Parse(reader["OtherFees_Balance"].ToString());
                    item.OtherFees_Status = reader["OtherFees_Status"].ToString();
                    item.OtherFees_PaymentMade = Decimal.Parse(reader["OtherFees_PaymentMade"].ToString());
                    item.OtherFees_DueDate = reader["OtherFees_DueDate"].ToString();
                    item.OtherFees_CutOffDate = reader["OtherFees_CutOffDate"].ToString();
                    item.OtherFees_IsOld = reader["OtherFees_IsOld"].ToString();
                    item.OtherFees_Deleted = reader["OtherFees_Deleted"].ToString();

                    otherFeesCollect.Add(item);
                }
                db.Close();
            }
        }
            public void LoadSelectedOtherFeesFromDb(string selDescription)
        {
            otherFeesCollect = new List<OtherFeesItem>();
            otherFeesCollect.Clear();

            using (var db = Connection.CreateConnection())
            {
                db.Open();

                var sql = "dbo.spGetSelectedOtherFeesDescription";
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
                    var item = new OtherFeesItem();

                    item.OtherFees_Id = Int32.Parse(reader["OtherFees_Id"].ToString());
                    item.OtherFees_Bill_Id = Int32.Parse(reader["OtherFees_Bill_Id"].ToString());
                    item.OtherFees_Std_Id = Int32.Parse(reader["OtherFees_Std_Id"].ToString());
                    item.OtherFees_Description = reader["OtherFees_Description"].ToString();
                    item.OtherFees_Amount = Decimal.Parse(reader["OtherFees_Amount"].ToString());
                    item.OtherFees_DatePaid = reader["OtherFees_DatePaid"].ToString();
                    item.OtherFees_Balance = Decimal.Parse(reader["OtherFees_Balance"].ToString());
                    item.OtherFees_Status = reader["OtherFees_Status"].ToString();
                    item.OtherFees_PaymentMade = Decimal.Parse(reader["OtherFees_PaymentMade"].ToString());
                    item.OtherFees_DueDate = reader["OtherFees_DueDate"].ToString();
                    item.OtherFees_CutOffDate = reader["OtherFees_CutOffDate"].ToString();
                    item.OtherFees_IsOld = reader["OtherFees_IsOld"].ToString();
                    item.OtherFees_Deleted = reader["OtherFees_Deleted"].ToString();

                    otherFeesCollect.Add(item);
                }
                db.Close();
            }
        }
        public void LoadSelectedOtherFeesWithBillIdFromDb(string selDescription, int BillId)
        {
            otherFeesCollect = new List<OtherFeesItem>();
            otherFeesCollect.Clear();

            using (var db = Connection.CreateConnection())
            {
                db.Open();

                var sql = "dbo.spGetSelectedOtherFeesDescriptionWithBillId";
                var cmd = new SqlCommand(sql, db);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Description", selDescription));
                cmd.Parameters.Add(new SqlParameter("@BillId", BillId));
                var reader = cmd.ExecuteReader();

                if (!reader.HasRows)
                {
                    return;
                }

                while (reader.Read())
                {
                    var item = new OtherFeesItem();

                    item.OtherFees_Id = Int32.Parse(reader["OtherFees_Id"].ToString());
                    item.OtherFees_Bill_Id = Int32.Parse(reader["OtherFees_Bill_Id"].ToString());
                    item.OtherFees_Std_Id = Int32.Parse(reader["OtherFees_Std_Id"].ToString());
                    item.OtherFees_Description = reader["OtherFees_Description"].ToString();
                    item.OtherFees_Amount = Decimal.Parse(reader["OtherFees_Amount"].ToString());
                    item.OtherFees_DatePaid = reader["OtherFees_DatePaid"].ToString();
                    item.OtherFees_Balance = Decimal.Parse(reader["OtherFees_Balance"].ToString());
                    item.OtherFees_Status = reader["OtherFees_Status"].ToString();
                    item.OtherFees_PaymentMade = Decimal.Parse(reader["OtherFees_PaymentMade"].ToString());
                    item.OtherFees_DueDate = reader["OtherFees_DueDate"].ToString();
                    item.OtherFees_CutOffDate = reader["OtherFees_CutOffDate"].ToString();
                    item.OtherFees_IsOld = reader["OtherFees_IsOld"].ToString();
                    item.OtherFees_Deleted = reader["OtherFees_Deleted"].ToString();

                    otherFeesCollect.Add(item);
                }
                db.Close();
            }
        }
        public void GetOtherFeesDescriptionFromDb()
        {
            //otherFeesCollect = new List<OtherFeesItem>();
            otherFeesCollect.Clear();

            using (var db = Connection.CreateConnection())
            {
                db.Open();

                var sql = "dbo.spGetOtherFeesByDescription";
                var cmd = new SqlCommand(sql, db);
                var reader = cmd.ExecuteReader();

                if (!reader.HasRows)
                {
                    return;
                }

                while (reader.Read())
                {
                    var item = new OtherFeesItem();
                    
                    item.OtherFees_Description = reader["OtherFees_Description"].ToString();
                    if (otherFeesCollect.Count == 0)
                    {
                        otherFeesCollect.Add(item);
                    }
                    else if (otherFeesCollect.All(x => (x.OtherFees_Description != item.OtherFees_Description)))
                    {
                        otherFeesCollect.Add(item);
                    }
                }
                db.Close();
            }
        }
        public void GetOtherFeesDescriptionWithBillIdFromDb(int billId)
        {
            //otherFeesCollect = new List<OtherFeesItem>();
            otherFeesCollect.Clear();

            using (var db = Connection.CreateConnection())
            {
                db.Open();

                var sql = "dbo.spGetOtherFeesByDescriptionWithBillId";
                var cmd = new SqlCommand(sql, db);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@BillId", billId));
                var reader = cmd.ExecuteReader();

                if (!reader.HasRows)
                {
                    return;
                }

                while (reader.Read())
                {
                    var item = new OtherFeesItem();

                    item.OtherFees_Description = reader["OtherFees_Description"].ToString();
                    if (otherFeesCollect.Count == 0)
                    {
                        otherFeesCollect.Add(item);
                    }
                    else if (otherFeesCollect.All(x => (x.OtherFees_Description != item.OtherFees_Description)))
                    {
                        otherFeesCollect.Add(item);
                    }
                }
                db.Close();
            }
        }
    }
}
