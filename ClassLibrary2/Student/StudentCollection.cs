using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentBillingLibrary
{
    public class StudentCollection
    {
        private List<StudentItem> studentCollect = new List<StudentItem>();
                    
        public List<StudentItem> pubStudentCollect
        {
            get { return studentCollect; }
        }

        public void LoadStudentsFromDb()
        {
            studentCollect = new List<StudentItem>();
            studentCollect.Clear();

            using (var db = Connection.CreateConnection())
            {
                db.Open();

                var sql = "dbo.spLoadStudents";
                var cmd = new SqlCommand(sql, db);
                var reader = cmd.ExecuteReader();

                if (!reader.HasRows)
                {
                    return;
                }

                while (reader.Read())
                {
                    var item = new StudentItem();

                    item.Std_Id = Int32.Parse(reader["Std_Id"].ToString());
                    item.Std_FName = reader["Std_FName"].ToString();
                    item.Std_MName = reader["Std_MName"].ToString();
                    item.Std_LName = reader["Std_LName"].ToString();
                    item.Std_CourseCode = reader["Std_CourseCode"].ToString();
                    item.Std_CourseTitle = reader["Std_CourseTitle"].ToString();
                    item.Std_Section = reader["Std_Section"].ToString();
                    item.Std_Year = reader["Std_Year"].ToString();

                    studentCollect.Add(item);
                }
                db.Close();
            }
        }
        public string LoadLogStudentsFromDb(string fName, string lName)
        {
            studentCollect = new List<StudentItem>();
            studentCollect.Clear();

            using (var db = Connection.CreateConnection())
            {
                db.Open();

                var sql = "dbo.spGetStudentLogin";
                var cmd = new SqlCommand(sql, db);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@FName", fName));
                cmd.Parameters.Add(new SqlParameter("@LName", lName));
                var reader = cmd.ExecuteReader();

                if (!reader.HasRows)
                {
                    return "Name Not Found";
                }

                while (reader.Read())
                {
                    var item = new StudentItem();

                    item.Std_Id = Int32.Parse(reader["Std_Id"].ToString());
                    item.Std_FName = reader["Std_FName"].ToString();
                    item.Std_MName = reader["Std_MName"].ToString();
                    item.Std_LName = reader["Std_LName"].ToString();
                    item.Std_CourseCode = reader["Std_CourseCode"].ToString();
                    item.Std_CourseTitle = reader["Std_CourseTitle"].ToString();
                    item.Std_Section = reader["Std_Section"].ToString();
                    item.Std_Year = reader["Std_Year"].ToString();

                    studentCollect.Add(item);
                }
                db.Close();
                return "Name Found";
            }
        }
        public string LoadLogStudentsWithIdFromDb(string fName, string lName, int Id)
        {
            studentCollect = new List<StudentItem>();
            studentCollect.Clear();

            using (var db = Connection.CreateConnection())
            {
                db.Open();

                var sql = "dbo.spGetStudentLoginWithId";
                var cmd = new SqlCommand(sql, db);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@FName", fName));
                cmd.Parameters.Add(new SqlParameter("@LName", lName));
                cmd.Parameters.Add(new SqlParameter("@Id", Id));
                var reader = cmd.ExecuteReader();

                if (!reader.HasRows)
                {
                    return "Name Not Found";
                }

                while (reader.Read())
                {
                    var item = new StudentItem();

                    item.Std_Id = Int32.Parse(reader["Std_Id"].ToString());
                    item.Std_FName = reader["Std_FName"].ToString();
                    item.Std_MName = reader["Std_MName"].ToString();
                    item.Std_LName = reader["Std_LName"].ToString();
                    item.Std_CourseCode = reader["Std_CourseCode"].ToString();
                    item.Std_CourseTitle = reader["Std_CourseTitle"].ToString();
                    item.Std_Section = reader["Std_Section"].ToString();
                    item.Std_Year = reader["Std_Year"].ToString();

                    studentCollect.Add(item);
                }
                db.Close();
                return "Name Found";
            }
        }
        public void SearchStudent(string search)
        {
            using (var db = Connection.CreateConnection())
            {
                db.Open();

                var sql = "dbo.spLoadSearchedStudents";
                var cmd = new SqlCommand(sql, db);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Search", string.Format("%{0}%", search)));
                var reader = cmd.ExecuteReader();

                if (!reader.HasRows)
                {
                    return;
                }

                while (reader.Read())
                {
                    var item = new StudentItem();

                    item.Std_Id = Int32.Parse(reader["Std_Id"].ToString());
                    item.Std_FName = reader["Std_FName"].ToString();
                    item.Std_LName = reader["Std_LName"].ToString();
                    item.Std_MName = reader["Std_MName"].ToString();
                    item.Std_CourseCode = reader["Std_CourseCode"].ToString();
                    item.Std_CourseTitle = reader["Std_CourseTitle"].ToString();
                    item.Std_Year = reader["Std_Year"].ToString();
                    item.Std_Section = reader["Std_Section"].ToString();

                    studentCollect.Add(item);
                }

                db.Close();
            }
        }
    }
}
