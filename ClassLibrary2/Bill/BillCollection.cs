using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentBillingLibrary
{
    public class BillCollection
    {
        private List<BillItem> billCollect = new List<BillItem>();

        public List<BillItem> pubBillCollect
        {
            get { return billCollect; }
        }

        public void LoadBillFromDb()
        {
            billCollect = new List<BillItem>();
            billCollect.Clear();

            using (var db = Connection.CreateConnection())
            {
                db.Open();

                var sql = "dbo.spLoadBill";
                var cmd = new SqlCommand(sql, db);
                var reader = cmd.ExecuteReader();

                if (!reader.HasRows)
                {
                    return;
                }

                while (reader.Read())
                {
                    var item = new BillItem();

                    item.Bill_Id = Int32.Parse(reader["Bill_Id"].ToString());
                    item.Bill_Std_Id = Int32.Parse(reader["Bill_Std_Id"].ToString());
                    item.Bill_Description = reader["Bill_Description"].ToString();
                    item.Bill_TotalAmount = Decimal.Parse(reader["Bill_TotalAmount"].ToString());
                    item.Bill_Discount = Int32.Parse(reader["Bill_Discount"].ToString());
                    item.Bill_Status = reader["Bill_Status"].ToString();
                    item.Bill_PaymentMade = Decimal.Parse(reader["Bill_PaymentMade"].ToString());
                    item.Bill_DatePaid = reader["Bill_DatePaid"].ToString();
                    item.Bill_Balance = Decimal.Parse(reader["Bill_Balance"].ToString());
                    item.Bill_Semester = reader["Bill_Semester"].ToString();
                    item.Bill_SchoolYear = reader["Bill_SchoolYear"].ToString();
                    item.Bill_DueDate = reader["Bill_DueDate"].ToString();
                    item.Bill_IsOld = reader["Bill_IsOld"].ToString();
                    item.Bill_Deleted = reader["Bill_Deleted"].ToString();

                    billCollect.Add(item);
                }
                db.Close();
            }
        }
        public void LoadBillWithStdIdFromDb(int stdId)
        {
            billCollect = new List<BillItem>();
            billCollect.Clear();

            using (var db = Connection.CreateConnection())
            {
                db.Open();

                var sql = "dbo.spLoadBillWithStdId";
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
                    var item = new BillItem();

                    item.Bill_Id = Int32.Parse(reader["Bill_Id"].ToString());
                    item.Bill_Std_Id = Int32.Parse(reader["Bill_Std_Id"].ToString());
                    item.Bill_Description = reader["Bill_Description"].ToString();
                    item.Bill_TotalAmount = Decimal.Parse(reader["Bill_TotalAmount"].ToString());
                    item.Bill_Discount = Int32.Parse(reader["Bill_Discount"].ToString());
                    item.Bill_FinalAmount = Decimal.Parse(reader["Bill_FinalAmount"].ToString());
                    item.Bill_Status = reader["Bill_Status"].ToString();
                    item.Bill_PaymentMade = Decimal.Parse(reader["Bill_PaymentMade"].ToString());
                    item.Bill_DatePaid = reader["Bill_DatePaid"].ToString();
                    item.Bill_Balance = Decimal.Parse(reader["Bill_Balance"].ToString());
                    item.Bill_Semester = reader["Bill_Semester"].ToString();
                    item.Bill_SchoolYear = reader["Bill_SchoolYear"].ToString();
                    item.Bill_DueDate = reader["Bill_DueDate"].ToString();
                    item.Bill_IsOld = reader["Bill_IsOld"].ToString();
                    item.Bill_Deleted = reader["Bill_Deleted"].ToString();

                    billCollect.Add(item);
                    LoginUser.stdLogStudentBillId = item.Bill_Id.ToString();
                }
                db.Close();
            }
        }
        public void LoadOldBillWithStdIdFromDb(int stdId)
        {
            billCollect = new List<BillItem>();
            billCollect.Clear();

            using (var db = Connection.CreateConnection())
            {
                db.Open();

                var sql = "dbo.spLoadOldBillWithStdId";
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
                    var item = new BillItem();

                    item.Bill_Id = Int32.Parse(reader["Bill_Id"].ToString());
                    item.Bill_Std_Id = Int32.Parse(reader["Bill_Std_Id"].ToString());
                    item.Bill_Description = reader["Bill_Description"].ToString();
                    item.Bill_TotalAmount = Decimal.Parse(reader["Bill_TotalAmount"].ToString());
                    item.Bill_Discount = Int32.Parse(reader["Bill_Discount"].ToString());
                    item.Bill_FinalAmount = Decimal.Parse(reader["Bill_FinalAmount"].ToString());
                    item.Bill_Status = reader["Bill_Status"].ToString();
                    item.Bill_PaymentMade = Decimal.Parse(reader["Bill_PaymentMade"].ToString());
                    item.Bill_DatePaid = reader["Bill_DatePaid"].ToString();
                    item.Bill_Balance = Decimal.Parse(reader["Bill_Balance"].ToString());
                    item.Bill_Semester = reader["Bill_Semester"].ToString();
                    item.Bill_SchoolYear = reader["Bill_SchoolYear"].ToString();
                    item.Bill_DueDate = reader["Bill_DueDate"].ToString();
                    item.Bill_IsOld = reader["Bill_IsOld"].ToString();
                    item.Bill_Deleted = reader["Bill_Deleted"].ToString();

                    billCollect.Add(item);
                }
                db.Close();
            }
        }
    }
}
