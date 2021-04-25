using NorthWind.NorthWindDB.Entites;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.NorthWindDB.ORM.MsSqlServer
{
    public class MsSqlOperation : IDatabaseOperation
    {
        SqlConnection sqlConnection;
        public MsSqlOperation()
        {
            sqlConnection = ContextDb.Connection;
        }
        public bool CreateDatabase()
        {
            string dbName = GetDbName();
            SqlConnection masterSqlConnection = new SqlConnection(GetMasterDbConnection(sqlConnection.ConnectionString));
            if (!IsExistDb(masterSqlConnection, dbName))
            {
                string command = $"CREATE DATABASE {dbName}";
                SqlCommand sqlCommand = new SqlCommand(command, masterSqlConnection);
                masterSqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                masterSqlConnection.Close();
                return true;
            }
            return false;
        }
        public void CreateTable<T>() where T : IEntity
        {
            Type type = typeof(T);
            string sqlCommandText = CreateTableCommand(type);
            SqlCommand sqlCommand = new SqlCommand(sqlCommandText, sqlConnection);
            OpenConnection();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        private bool IsExistDb(SqlConnection connectionString, string databaseName)
        {

            string sqlCreateDBQuery = $"SELECT database_id FROM sys.databases WHERE Name = '{databaseName}'";

            SqlCommand sqlCmd = new SqlCommand(sqlCreateDBQuery, connectionString);

            connectionString.Open();

            object resultObj = sqlCmd.ExecuteScalar();

            int databaseID = 0;

            if (resultObj != null)
            {
                int.TryParse(resultObj.ToString(), out databaseID);
            }

            connectionString.Close();
            sqlCmd.Dispose();

            return (databaseID > 0);
        }
        private string CreateTableCommand(Type type)
        {
            string init = $"CREATE TABLE dbo.{type.Name}(";
            string end = null;
            foreach (var item in type.GetProperties())
            {
                EntityReflection entityReflection = new EntityReflection(item);


                if (entityReflection.Identity)
                {
                    init += $"{entityReflection.PropertyName} {entityReflection.PropertyType} IDENTITY(1,1) NOT NULL,";
                }
                else
                {
                    init += $"{entityReflection.PropertyName} {entityReflection.PropertyType} {entityReflection.Required},";
                }
                if (entityReflection.Key)
                {
                    end = $"CONSTRAINT pk_{item.Name}{type.Name} PRIMARY KEY({item.Name}))";
                }
            }
            return $"{init} {end}";
        }
        private string GetMasterDbConnection(string sqlConnection)
        {
            string[] split = sqlConnection.Split(" ");
            string newSqlConneciton = null;
            for (int i = 0; i < split.Length; i++)
            {
                if (split[i].StartsWith("database"))
                {
                    string subString = split[i].Remove(9);
                    subString += "master;";
                    split[i] = subString;
                }
                newSqlConneciton += $"{split[i]} ";
            }
            return newSqlConneciton;
        }
        private string GetDbName()
        {
            string subString = null;
            string[] split = sqlConnection.ConnectionString.Split(" ");
            for (int i = 0; i < split.Length; i++)
            {
                if (split[i].StartsWith("database"))
                {
                    subString = split[i].Substring(9);
                    subString = subString.Remove(subString.Length - 1);
                }
            }
            return subString;
        }
        public void Add<TEntity>(TEntity entity) where TEntity : IEntity
        {
            Type type = typeof(TEntity);
            string command = $"INSERT INTO dbo.{type.Name} values(";
            foreach (var item in type.GetProperties())
            {
                string name = item.Name.ToLower(new CultureInfo("en-US"));
                if (name!="id"&&name!=$"{type.Name}id")
                {
                    if (item.PropertyType == typeof(DateTime))
                    {
                        command += $"'{((DateTime)item.GetValue(entity)).ToString("yyyy-MM-dd HH:mm:ss")}',";
                    }
                    else
                    {
                        command += $"'{item.GetValue(entity)}',";
                    }
                }

            }
            command = command.Remove(command.Length - 1);
            command += ")";
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);

            OpenConnection();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public DbDataReader GetEntities<TEntity>(out DbConnection dbConnection) where TEntity : IEntity
        {
            Type type = typeof(TEntity);
            string command = $"Select * from dbo.{type.Name}";
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
            OpenConnection();
            DbDataReader dbDataReader = sqlCommand.ExecuteReader();
            dbConnection = sqlConnection;
            return dbDataReader;
        }

        private void OpenConnection()
        {
            if (sqlConnection.State==ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }
    }
}
