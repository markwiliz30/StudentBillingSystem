using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentBillingLibrary
{
    public class StaffCollection
    {
        private List<StaffItem> staffCollect = new List<StaffItem>();

        public List<StaffItem> pubStaffCollect
        {
            get { return staffCollect; }
        }

        public string LoadLogStaffFromDb(string userName)
        {
            staffCollect = new List<StaffItem>();
            staffCollect.Clear();

            using (var db = Connection.CreateConnection())
            {
                db.Open();

                var sql = "dbo.spGetStaffLogin";
                var cmd = new SqlCommand(sql, db);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@UserName", userName));
                var reader = cmd.ExecuteReader();

                if (!reader.HasRows)
                {
                    return "Name Not Found";
                }

                while (reader.Read())
                {
                    var item = new StaffItem();

                    item.Staff_Id = Int32.Parse(reader["Staff_Id"].ToString());
                    item.Staff_Position = reader["Staff_Position"].ToString();
                    item.Staff_FName = reader["Staff_FName"].ToString();
                    item.Staff_MName = reader["Staff_MName"].ToString();
                    item.Staff_LName = reader["Staff_LName"].ToString();
                    item.Staff_Username = reader["Staff_Username"].ToString();
                    item.Staff_Password = reader["Staff_Password"].ToString();
                    item.Staff_Deleted = reader["Staff_Deleted"].ToString();

                    staffCollect.Add(item);
                }
                db.Close();
                return "Name Found";
            }
        }
        public void LoadStaffFromDb()
        {
            staffCollect = new List<StaffItem>();
            staffCollect.Clear();

            using (var db = Connection.CreateConnection())
            {
                db.Open();

                var sql = "dbo.spLoadAcc";
                var cmd = new SqlCommand(sql, db);
                var reader = cmd.ExecuteReader();

                if (!reader.HasRows)
                {
                    return;
                }

                while (reader.Read())
                {
                    var item = new StaffItem();

                    item.Staff_Position = reader["Staff_Position"].ToString();
                    item.Staff_FName = reader["Staff_FName"].ToString();
                    item.Staff_LName = reader["Staff_LName"].ToString();
                    item.Staff_MName = reader["Staff_MName"].ToString();
                    item.Staff_Username = reader["Staff_Username"].ToString();
                    item.Staff_Password = reader["Staff_Password"].ToString();
                    item.Staff_Id = Int32.Parse(reader["Staff_Id"].ToString());

                    staffCollect.Add(item);
                }
                db.Close();
            }
        }
    }
}
