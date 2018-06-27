using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace StudentBillingLibrary
{
    public static class Connection
    {
        public static SqlConnection CreateConnection()
        {
            var builder = new SqlConnectionStringBuilder()
            {
                DataSource = "MARK-PC",
                InitialCatalog = "StudentBillingDB",
                IntegratedSecurity = true,

            };

            var db = new SqlConnection(builder.ToString());

            return db;
        }
    }
}
