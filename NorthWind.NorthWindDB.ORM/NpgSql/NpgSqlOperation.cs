﻿using NorthWind.NorthWindDB.Entites;
using NorthWind.NorthWindDB.ORM.MsSqlServer;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.NorthWindDB.ORM.NpgSql
{
    public class NpgSqlOperation : IDatabaseOperation
    {
        NpgsqlConnection npgsqlConnection;

        Dictionary<string, string> dataType = new Dictionary<string, string>
        {
            { "Int32", "int" },
            { "DateTime", "timestamp without time zone" },
            { "String", "varchar(2000)" },
            { "Int16", "smallint" }
        };
        public NpgSqlOperation()
        {
            npgsqlConnection = NpgSqlContext.Connection;
        }

        public bool CreateDatabase()
        {
            string dbName = GetDbName();
            NpgsqlConnection masterSqlConnection = new NpgsqlConnection(GetPostgresDbConnection(npgsqlConnection.ConnectionString));
            if (!IsExistDb(masterSqlConnection, dbName))
            {
                string command = $"CREATE DATABASE {dbName}";
                NpgsqlCommand sqlCommand = new NpgsqlCommand(command, masterSqlConnection);
                masterSqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                masterSqlConnection.Close();
                GetToLowerConnection(dbName);
                return true;
            }
            return false;
        }

        private bool IsExistDb(NpgsqlConnection connectionString, string databaseName)
        {

            string sqlCreateDBQuery = $"SELECT oid from pg_database where datname = '{databaseName}'";

            NpgsqlCommand sqlCmd = new NpgsqlCommand(sqlCreateDBQuery, connectionString);

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

        public void CreateTable<T>() where T : IEntity
        {
            Type type = typeof(T);
            string sqlCommandText = CreateTableCommand(type);

            NpgsqlCommand sqlCommand = new NpgsqlCommand(sqlCommandText, npgsqlConnection);
            OpenConnection();
            sqlCommand.ExecuteNonQuery();
            npgsqlConnection.Close();
            sqlCommand.Dispose();
        }

        private string CreateTableCommand(Type type)
        {
            // 
            string init = $"CREATE TABLE IF NOT EXISTS public.\"{ type.Name}\"(";
            foreach (var item in type.GetProperties())
            {
                EntityReflection entityReflection = new EntityReflection(item, dataType);


                if (entityReflection.Identity)
                {
                    init += $"\"{entityReflection.PropertyName}\" {entityReflection.PropertyType}  NOT NULL PRIMARY KEY GENERATED BY DEFAULT AS IDENTITY ( INCREMENT 1 START 1 MINVALUE 1 MAXVALUE 2147483647 CACHE 1 ),";
                }
                else
                {
                    init += $"\"{entityReflection.PropertyName}\" {entityReflection.PropertyType} {entityReflection.Required},";
                }

            }
            init = init.Remove(init.Length - 1);
            return $"{init})";
        }

        public DbDataReader GetEntities<TEntity>(out DbConnection dbConnection) where TEntity : IEntity
        {
            throw new NotImplementedException();
        }

        public void Add<TEntity>(TEntity entity) where TEntity : IEntity
        {
            Type type = typeof(TEntity);
            string command = $"INSERT INTO public.\"{type.Name}\"(";
            foreach (var item in type.GetProperties())
            {
                string name = item.Name.ToLower(new CultureInfo("en-US"));
                if (name != "id" && name != $"{type.Name}id")
                {
                    command += $"\"{item.Name}\",";
                }
            }
            command = command.Remove(command.Length - 1);
            command += ") VALUES (";
            foreach (var item in type.GetProperties())
            {
                string name = item.Name.ToLower(new CultureInfo("en-US"));
                if (name != "id" && name != $"{type.Name}id")
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
            NpgsqlCommand sqlCommand = new NpgsqlCommand(command, npgsqlConnection);
            npgsqlConnection.Open();
            int i=sqlCommand.ExecuteNonQuery();
            npgsqlConnection.Close();
        }

        private string GetPostgresDbConnection(string sqlConnection)
        {
            string[] split = sqlConnection.Split(" ");
            string newSqlConneciton = null;
            for (int i = 0; i < split.Length; i++)
            {
                if (split[i].ToLower().StartsWith("database"))
                {
                    string subString = split[i].Remove(9);
                    subString += "postgres;";
                    split[i] = subString;
                }
                newSqlConneciton += $"{split[i]} ";
            }
            return newSqlConneciton;
        }

        private void GetToLowerConnection(string dbName)
        {
            string[] split = npgsqlConnection.ConnectionString.Split(" ");
            string newSqlConneciton = null;
            for (int i = 0; i < split.Length; i++)
            {
                if (split[i].ToLower().StartsWith("database"))
                {
                    string subString = split[i].Remove(9);
                    subString += $"{dbName};";
                    split[i] = subString;
                }
                newSqlConneciton += $"{split[i]} ";
            }
            npgsqlConnection.ConnectionString = newSqlConneciton;
        }
        private string GetDbName()
        {
            string subString = null;
            string[] split = npgsqlConnection.ConnectionString.Split(" ");
            for (int i = 0; i < split.Length; i++)
            {
                if (split[i].ToLower().StartsWith("database"))
                {
                    subString = split[i].Substring(9);
                    subString = subString.Remove(subString.Length - 1);
                }
            }
            return subString.ToLower();
        }

        private void OpenConnection()
        {
            if (npgsqlConnection.State == ConnectionState.Closed)
            {
                npgsqlConnection.Open();
            }
        }
    }
}