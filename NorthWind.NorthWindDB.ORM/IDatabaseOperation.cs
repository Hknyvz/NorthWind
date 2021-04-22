using NorthWind.NorthWindDB.Entites.LogEntities;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.NorthWindDB.ORM
{
    public interface IDatabaseOperation
    {
        bool CreateDatabase();
        void CreateTable<T>()where T:IEntity;
        void Add<TEntity>(TEntity entity) where TEntity : IEntity;
    }
}
