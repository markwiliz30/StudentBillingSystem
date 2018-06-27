using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentBillingLibrary
{
    public class PartialPaymentCollection
    {
        private List<PartialPaymentItem> partialPaymentCollect = new List<PartialPaymentItem>();
        public List<PartialPaymentItem> pubOtherFeesCollect
        {
            get { return partialPaymentCollect; }
        }
        public void LoadPartialPaymentWithIdsFromDb(int BillId, int StdId)
        {
            partialPaymentCollect = new List<PartialPaymentItem>();
            partialPaymentCollect.Clear();

            using (var db = Connection.CreateConnection())
            {
                db.Open();

                var sql = "dbo.spLoadPartialPaymentsWithIds";
                var cmd = new SqlCommand(sql, db);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@BillId", BillId));
                cmd.Parameters.Add(new SqlParameter("@StdId", StdId));
                var reader = cmd.ExecuteReader();

                if (!reader.HasRows)
                {
                    return;
                }

                while (reader.Read())
                {
                    var item = new PartialPaymentItem();

                    item.PartPay_Id = Int32.Parse(reader["PartPay_Id"].ToString());
                    item.PartPay_Bill_Id = Int32.Parse(reader["PartPay_Bill_Id"].ToString());
                    item.PartPay_Std_Id = Int32.Parse(reader["PartPay_Std_Id"].ToString());
                    item.PartPay_Partition = reader["PartPay_Partition"].ToString();
                    item.PartPay_Amount = Decimal.Parse(reader["PartPay_Amount"].ToString());
                    item.PartPay_Balance = Decimal.Parse(reader["PartPay_Balance"].ToString());
                    item.PartPay_DueDate = reader["PartPay_DueDate"].ToString();
                    item.PartPay_DatePaid = reader["PartPay_DatePaid"].ToString();
                    item.PartPay_PaymentMade = Decimal.Parse(reader["PartPay_PaymentMade"].ToString());
                    item.PartPay_Status = reader["PartPay_Status"].ToString();
                    item.PartPay_Deleted = reader["PartPay_Deleted"].ToString();

                    partialPaymentCollect.Add(item);
                }
                db.Close();
            }
        }
        public void LoadOldPartWithStdIdFromDb(int stdId)
        {
            partialPaymentCollect = new List<PartialPaymentItem>();
            partialPaymentCollect.Clear();

            using (var db = Connection.CreateConnection())
            {
                db.Open();

                var sql = "dbo.spTransferOldBal";
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
                    var item = new PartialPaymentItem();

                    item.PartPay_Id = Int32.Parse(reader["PartPay_Id"].ToString());
                    item.PartPay_Bill_Id = Int32.Parse(reader["PartPay_Bill_Id"].ToString());
                    item.PartPay_Std_Id = Int32.Parse(reader["PartPay_Std_Id"].ToString());
                    item.PartPay_Partition = reader["PartPay_Partition"].ToString();
                    item.PartPay_Amount = Decimal.Parse(reader["PartPay_Amount"].ToString());
                    item.PartPay_Balance = Decimal.Parse(reader["PartPay_Balance"].ToString());
                    item.PartPay_DueDate = reader["PartPay_DueDate"].ToString();
                    item.PartPay_DatePaid = reader["PartPay_DatePaid"].ToString();
                    item.PartPay_PaymentMade = Decimal.Parse(reader["PartPay_PaymentMade"].ToString());
                    item.PartPay_Status = reader["PartPay_Status"].ToString();
                    item.PartPay_Deleted = reader["PartPay_Deleted"].ToString();

                    partialPaymentCollect.Add(item);
                }
                db.Close();
            }
        }
    }
}
