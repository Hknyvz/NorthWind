using NorthWind.NorthWindDB.DAL.LogDAL.Abstract;
using NorthWind.NorthWindDB.Entites.LogEntities;
using NorthWind.NorthWindDB.ORM;
using System;
using System.Collections.Generic;
using System.Data.Common;
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

        public ICollection<RequestLog> GetRequestLogs()
        {
            DbDataReader dbDataReader = databaseOperation.GetEntities<RequestLog>(out DbConnection dbConnection);

            return FillData(dbDataReader,dbConnection);
        }

        private static ICollection<RequestLog> FillData(DbDataReader dbDataReader, DbConnection dbConnection)
        {
            ICollection<RequestLog> requestLogs = new HashSet<RequestLog>();

            while (dbDataReader.Read())
            {
                RequestLog request = new RequestLog
                {
                    Id = Convert.ToInt32(dbDataReader["id"]),
                    Method = dbDataReader["Method"].ToString(),
                    Body = dbDataReader["Body"].ToString(),
                    CreateDate = Convert.ToDateTime(dbDataReader["CreateDate"]),
                    SubQuery = dbDataReader["SubQuery"].ToString(),
                    Path = dbDataReader["Path"].ToString()
                };
                requestLogs.Add(request);
            }
            dbConnection.Close();
            return requestLogs;
        }
    }
}
