using Microsoft.Extensions.Configuration;
using Npgsql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.NorthWindDB.ORM.NpgSql
{
    public class NpgSqlContext
    {
        private static NpgsqlConnection connection;

        public static NpgsqlConnection Connection
        {
            get
            {
                IConfiguration configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
                string connectionString = configuration.GetConnectionString("NpgSql");

                string[] split = connectionString.Split(" ");
                string newSqlConneciton = null;
                string dbName = null;
                for (int i = 0; i < split.Length; i++)
                {
                    if (split[i].ToLower().StartsWith("database"))
                    {

                        dbName = split[i].Substring(9);
                        dbName = dbName.Remove(dbName.Length - 1);
                    }
                    if (split[i].ToLower().StartsWith("database"))
                    {
                        string subString = split[i].Remove(9);
                        subString += $"{dbName.ToLower()};";
                        split[i] = subString;
                    }
                    newSqlConneciton += $"{split[i]} ";
                }

                return connection=connection=null??new NpgsqlConnection(newSqlConneciton);
            }
            set
            {
                connection = value;
            }
        }
    }
}

