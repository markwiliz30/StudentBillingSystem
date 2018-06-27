using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentBillingLibrary
{
    public class OtherPayments
    {
        private List<OtherFeesPaymentItem> otherPaymentCollect = new List<OtherFeesPaymentItem>();

        public List<OtherFeesPaymentItem> pubOtherPaymentCollect
        {
            get { return otherPaymentCollect; }
        }
        private List<OtherFeesItem> otherCollect = new List<OtherFeesItem>();

        public List<OtherFeesItem> pubOtherCollect
        {
            get { return otherCollect; }
        }
        public void LoadJoinOtherPaymentsFromDb(int stdId)
        {
            otherPaymentCollect = new List<OtherFeesPaymentItem>();
            otherCollect = new List<OtherFeesItem>();
            otherPaymentCollect.Clear();
            otherCollect.Clear();

            using (var db = Connection.CreateConnection())
            {
                db.Open();

                var sql = "dbo.spJoinOtherPayments";
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
                    var item = new OtherFeesPaymentItem();
                    var item2 = new OtherFeesItem();

                    item.OtherPay_Id = Int32.Parse(reader["OtherPay_Id"].ToString());
                    item.OtherPay_OtherFees_Id = Int32.Parse(reader["OtherPay_OtherFees_Id"].ToString());
                    item.OtherPay_Bill_Id = Int32.Parse(reader["OtherPay_Bill_Id"].ToString());
                    item.OtherPay_Std_Id = Int32.Parse(reader["OtherPay_Std_Id"].ToString());
                    item.OtherPay_Number = Int32.Parse(reader["OtherPay_Number"].ToString());
                    item.OtherPay_Paid = Decimal.Parse(reader["OtherPay_Paid"].ToString());
                    item.OtherPay_DatePaid = reader["OtherPay_DatePaid"].ToString();
                    item.OtherPay_Deleted = reader["OtherPay_Deleted"].ToString();

                    item2.OtherFees_Id = Int32.Parse(reader["OtherFees_Id"].ToString());
                    item2.OtherFees_Bill_Id = Int32.Parse(reader["OtherFees_Bill_Id"].ToString());
                    item2.OtherFees_Std_Id = Int32.Parse(reader["OtherFees_Std_Id"].ToString());
                    item2.OtherFees_Description = reader["OtherFees_Description"].ToString();
                    item2.OtherFees_Amount = Decimal.Parse(reader["OtherFees_Amount"].ToString());
                    item2.OtherFees_Balance = Decimal.Parse(reader["OtherFees_Balance"].ToString());
                    item2.OtherFees_DueDate = reader["OtherFees_DueDate"].ToString();
                    item2.OtherFees_DatePaid = reader["OtherFees_DatePaid"].ToString();
                    item2.OtherFees_PaymentMade = Decimal.Parse(reader["OtherFees_PaymentMade"].ToString());
                    item2.OtherFees_CutOffDate = reader["OtherFees_CutOffDate"].ToString();
                    item2.OtherFees_Status = reader["OtherFees_Status"].ToString();
                    item2.OtherFees_IsOld = reader["OtherFees_IsOld"].ToString();
                    item2.OtherFees_Deleted = reader["OtherFees_Deleted"].ToString();

                    otherPaymentCollect.Add(item);
                    otherCollect.Add(item2);
                }
                db.Close();
            }
        }
    }
}
