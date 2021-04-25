using NorthWind.NorthWindDB.Entites;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.NorthWindDB.ORM.NpgSql
{
    public class NpgSqlOperation : IDatabaseOperation
    {
        public NpgSqlOperation()
        {
            NpgsqlConnection sqlConnection = new NpgsqlConnection("");
        }
        public void Add<TEntity>(TEntity entity) where TEntity : IEntity
        {
            throw new NotImplementedException();
        }

        public bool CreateDatabase()
        {
            throw new NotImplementedException();
        }

        public void CreateTable<T>() where T : IEntity
        {
            throw new NotImplementedException();
        }

        public DbDataReader GetEntities<TEntity>(out DbConnection dbConnection) where TEntity : IEntity
        {
            throw new NotImplementedException();
        }
    }
}
