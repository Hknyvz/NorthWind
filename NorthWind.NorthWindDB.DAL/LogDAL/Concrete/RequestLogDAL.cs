using NorthWind.NorthWindDB.DAL.LogDAL.Abstract;
using NorthWind.NorthWindDB.Entites.LogEntities;
using NorthWind.NorthWindDB.ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.NorthWindDB.DAL.LogDAL.Concrete
{
    public class RequestLogDAL : IRequestLogDAL
    {
        IDatabaseOperation databaseOperation;
        public RequestLogDAL(IDatabaseOperation databaseOperation)
        {
            this.databaseOperation = databaseOperation;
        }

        public void Add(RequestLog requestLog)
        {
            databaseOperation.Add(requestLog);
        }
    }
}
