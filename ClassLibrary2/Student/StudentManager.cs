using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentBillingLibrary;
using System.Data.SqlClient;
using System.Data;
using Dapper.Contrib.Extensions;
using Dapper;

namespace StudentBillingLibrary
{
    public class StudentManager
    {
        public int myReturnedID;
        public void SaveStudent(StudentItem stdItem)
        {
            using (var db = Connection.CreateConnection())
            {
                db.Open();

                var sql = "dbo.spInsertStudent";
                var cmd = new SqlCommand(sql, db);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@FName", stdItem.Std_FName));
                cmd.Parameters.Add(new SqlParameter("@LName", stdItem.Std_LName));
                cmd.Parameters.Add(new SqlParameter("@MName", stdItem.Std_MName));
                cmd.Parameters.Add(new SqlParameter("@CCode", stdItem.Std_CourseCode));
                cmd.Parameters.Add(new SqlParameter("@CTitle", stdItem.Std_CourseTitle));
                cmd.Parameters.Add(new SqlParameter("@Year", stdItem.Std_Year));
                cmd.Parameters.Add(new SqlParameter("@Section", stdItem.Std_Section));
                cmd.Parameters.Add(new SqlParameter("@Deleted", stdItem.Std_Deleted));

                myReturnedID = int.Parse(cmd.ExecuteScalar().ToString());

                db.Close();
            }
        }
        public void UpdateStudent(StudentItem stdItem)
        {
            using (var db = Connection.CreateConnection())
            {
                db.Open();

                var sql = "dbo.spUpdateStudent";
                var cmd = new SqlCommand(sql, db);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@FName", stdItem.Std_FName));
                cmd.Parameters.Add(new SqlParameter("@LName", stdItem.Std_LName));
                cmd.Parameters.Add(new SqlParameter("@MName", stdItem.Std_MName));
                cmd.Parameters.Add(new SqlParameter("@CCode", stdItem.Std_CourseCode));
                cmd.Parameters.Add(new SqlParameter("@CTitle", stdItem.Std_CourseTitle));
                cmd.Parameters.Add(new SqlParameter("@Year", stdItem.Std_Year));
                cmd.Parameters.Add(new SqlParameter("@Section", stdItem.Std_Section));
                cmd.Parameters.Add(new SqlParameter("@StdId", stdItem.Std_Id));

                cmd.ExecuteNonQuery();

                db.Close();
            }
        }
        public void DeleteStudent(int stdId)
        {
            using (var db = Connection.CreateConnection())
            {
                db.Open();

                var sql = "dbo.spDeleteStd";
                var cmd = new SqlCommand(sql, db);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@StdId", stdId));

                cmd.ExecuteNonQuery();

                db.Close();
            }
        }
    }
}
