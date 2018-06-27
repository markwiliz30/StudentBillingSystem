using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentBillingLibrary
{
    public class StaffManager
    {
        public void SaveStaff(StaffItem staffItem)
        {
            using (var db = Connection.CreateConnection())
            {
                db.Open();

                var sql = "dbo.spRegisterAcc";
                var cmd = new SqlCommand(sql, db);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Position", staffItem.Staff_Position));
                cmd.Parameters.Add(new SqlParameter("@FName", staffItem.Staff_FName));
                cmd.Parameters.Add(new SqlParameter("@LName", staffItem.Staff_LName));
                cmd.Parameters.Add(new SqlParameter("@MName", staffItem.Staff_MName));
                cmd.Parameters.Add(new SqlParameter("@UserName", staffItem.Staff_Username));
                cmd.Parameters.Add(new SqlParameter("@Password", staffItem.Staff_Password));

                cmd.ExecuteNonQuery();

                db.Close();
            }
        }
        public void UpdateStaff(StaffItem staffItem)
        {
            using (var db = Connection.CreateConnection())
            {
                db.Open();

                var sql = "dbo.spUpdateAcc";
                var cmd = new SqlCommand(sql, db);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Position", staffItem.Staff_Position));
                cmd.Parameters.Add(new SqlParameter("@FName", staffItem.Staff_FName));
                cmd.Parameters.Add(new SqlParameter("@LName", staffItem.Staff_LName));
                cmd.Parameters.Add(new SqlParameter("@MName", staffItem.Staff_MName));
                cmd.Parameters.Add(new SqlParameter("@UserName", staffItem.Staff_Username));
                cmd.Parameters.Add(new SqlParameter("@Password", staffItem.Staff_Password));
                cmd.Parameters.Add(new SqlParameter("@StaffId", staffItem.Staff_Id));

                cmd.ExecuteNonQuery();

                db.Close();
            }
        }
        public void DeleteAcc(int accId)
        {
            using (var db = Connection.CreateConnection())
            {
                db.Open();

                var sql = "dbo.spDeleteAcc";
                var cmd = new SqlCommand(sql, db);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@AccId", accId));

                cmd.ExecuteNonQuery();

                db.Close();
            }
        }
    }
}
