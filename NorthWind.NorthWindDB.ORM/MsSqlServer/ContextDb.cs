using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.NorthWindDB.ORM.MsSqlServer
{
    public class ContextDb
    {
        private static SqlConnection connection;

        public static SqlConnection Connection 
        {
            get 
            {
                IConfiguration configuration= new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
                string connectionString = configuration.GetConnectionString("MsSqlServer");
                return connection = connection ?? new SqlConnection(connectionString);
            }
            set 
            { 
                connection = value; 
            } 
        }
    }
}
