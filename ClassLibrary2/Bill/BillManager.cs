using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentBillingLibrary
{
    public class BillManager
    {
        public int myReturnedID;
        public void SaveBill(BillItem billItem)
        {
            using (var db = Connection.CreateConnection())
            {
                db.Open();

                var sql = "dbo.spInsertBill";
                var cmd = new SqlCommand(sql, db);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@BillStdId", billItem.Bill_Std_Id));
                cmd.Parameters.Add(new SqlParameter("@BillDescription", billItem.Bill_Description));
                cmd.Parameters.Add(new SqlParameter("@BillTotalAmount", billItem.Bill_TotalAmount));
                cmd.Parameters.Add(new SqlParameter("@BillFinalAmount", billItem.Bill_FinalAmount));
                cmd.Parameters.Add(new SqlParameter("@BillDiscount", billItem.Bill_Discount));
                cmd.Parameters.Add(new SqlParameter("@BillStatus", billItem.Bill_Status));
                cmd.Parameters.Add(new SqlParameter("@BillPaymentMade", billItem.Bill_PaymentMade));
                cmd.Parameters.Add(new SqlParameter("@BillDatePaid", billItem.Bill_DatePaid));
                cmd.Parameters.Add(new SqlParameter("@BillBalance", billItem.Bill_Balance));
                cmd.Parameters.Add(new SqlParameter("@BillSemester", billItem.Bill_Semester));
                cmd.Parameters.Add(new SqlParameter("@BillSchoolYear", billItem.Bill_SchoolYear));
                cmd.Parameters.Add(new SqlParameter("@BillDueDate", billItem.Bill_DueDate));
                cmd.Parameters.Add(new SqlParameter("@BillIsOld", billItem.Bill_IsOld));
                cmd.Parameters.Add(new SqlParameter("@BillDeleted", billItem.Bill_Deleted));

                myReturnedID = int.Parse(cmd.ExecuteScalar().ToString());

                db.Close();
            }
        }
        public void UpdateBill(BillItem Item)
        {
            using (var db = Connection.CreateConnection())
            {
                db.Open();

                var sql = "dbo.spUpdateBill";
                var cmd = new SqlCommand(sql, db);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@TotalAmount", Item.Bill_TotalAmount));
                cmd.Parameters.Add(new SqlParameter("@Discount", Item.Bill_Discount));
                cmd.Parameters.Add(new SqlParameter("@FinalAmount", Item.Bill_FinalAmount));
                cmd.Parameters.Add(new SqlParameter("@PayMade", Item.Bill_PaymentMade));
                cmd.Parameters.Add(new SqlParameter("@Balance", Item.Bill_Balance));
                cmd.Parameters.Add(new SqlParameter("@Semester", Item.Bill_Semester));
                cmd.Parameters.Add(new SqlParameter("@SchoolYear", Item.Bill_SchoolYear));
                cmd.Parameters.Add(new SqlParameter("@DueDate", Item.Bill_DueDate));
                cmd.Parameters.Add(new SqlParameter("@DatePaid", Item.Bill_DatePaid));
                cmd.Parameters.Add(new SqlParameter("@Status", Item.Bill_Status));
                cmd.Parameters.Add(new SqlParameter("@BillId", Item.Bill_Id));

                cmd.ExecuteNonQuery();

                db.Close();
            }
        }
        public void SetTuitionToOld(int billId)
        {
            using (var db = Connection.CreateConnection())
            {
                db.Open();

                var sql = "dbo.spSetOldBill";
                var cmd = new SqlCommand(sql, db);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@BillId", billId));

                cmd.ExecuteNonQuery();

                db.Close();
            }
        }
    }
}
