using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentBillingLibrary
{
    public class PaymentCollection
    {
        private List<PaymentItem> paymentCollect = new List<PaymentItem>();

        public List<PaymentItem> pubPayCollect
        {
            get { return paymentCollect; }
        }
        public void LoadPaymentsFromDb()
        {
            paymentCollect = new List<PaymentItem>();
            paymentCollect.Clear();

            using (var db = Connection.CreateConnection())
            {
                db.Open();

                var sql = "dbo.spLoadPayments";
                var cmd = new SqlCommand(sql, db);
                var reader = cmd.ExecuteReader();

                if (!reader.HasRows)
                {
                    return;
                }

                while(reader.Read())
                {
                    var item = new PaymentItem();

                    item.Payment_Id = Int32.Parse(reader["Payment_Id"].ToString());
                    item.Payment_PartPay_Id = Int32.Parse(reader["Payment_PartPay_Id"].ToString());
                    item.Payment_Bill_Id = Int32.Parse(reader["Payment_Bill_Id"].ToString());
                    item.Payment_Std_Id = Int32.Parse(reader["Payment_Std_Id"].ToString());
                    item.Payment_Number = Int32.Parse(reader["Payment_Number"].ToString());
                    item.Payment_Paid = Decimal.Parse(reader["Payment_Paid"].ToString());
                    item.Payment_DatePaid = reader["Payment_DatePaid"].ToString();
                    item.Payment_Deleted = reader["Payment_Deleted"].ToString();

                    paymentCollect.Add(item);
                }
                db.Close();
            }
        }
        public void LoadPaymentsWithBillIdFromDb(int oldId)
        {
            paymentCollect = new List<PaymentItem>();
            paymentCollect.Clear();

            using (var db = Connection.CreateConnection())
            {
                db.Open();

                var sql = "dbo.spLoadPaymentsWithOldId";
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
                    var item = new PaymentItem();
                    item.Payment_Id = Int32.Parse(reader["Payment_Id"].ToString());
                    item.Payment_PartPay_Id = Int32.Parse(reader["Payment_PartPay_Id"].ToString());
                    item.Payment_Bill_Id = Int32.Parse(reader["Payment_Bill_Id"].ToString());
                    item.Payment_Std_Id = Int32.Parse(reader["Payment_Std_Id"].ToString());
                    item.Payment_Number = Int32.Parse(reader["Payment_Number"].ToString());
                    item.Payment_Paid = Decimal.Parse(reader["Payment_Paid"].ToString());
                    item.Payment_DatePaid = reader["Payment_DatePaid"].ToString();
                    item.Payment_Deleted = reader["Payment_Deleted"].ToString();

                    paymentCollect.Add(item);
                }
                db.Close();
            }
        }
        public void LoadPaymentsWithPartialIdFromDb(int partId)
        {
            paymentCollect = new List<PaymentItem>();
            paymentCollect.Clear();

            using (var db = Connection.CreateConnection())
            {
                db.Open();

                var sql = "dbo.spLoadPaymentsWithPartId";
                var cmd = new SqlCommand(sql, db);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@PartId", partId));
                var reader = cmd.ExecuteReader();

                if (!reader.HasRows)
                {
                    return;
                }

                while (reader.Read())
                {
                    var item = new PaymentItem();
                    item.Payment_Id = Int32.Parse(reader["Payment_Id"].ToString());
                    item.Payment_PartPay_Id = Int32.Parse(reader["Payment_PartPay_Id"].ToString());
                    item.Payment_Bill_Id = Int32.Parse(reader["Payment_Bill_Id"].ToString());
                    item.Payment_Std_Id = Int32.Parse(reader["Payment_Std_Id"].ToString());
                    item.Payment_Number = Int32.Parse(reader["Payment_Number"].ToString());
                    item.Payment_Paid = Decimal.Parse(reader["Payment_Paid"].ToString());
                    item.Payment_DatePaid = reader["Payment_DatePaid"].ToString();
                    item.Payment_Deleted = reader["Payment_Deleted"].ToString();

                    paymentCollect.Add(item);
                }
                db.Close();
            }
        }
    }
}
