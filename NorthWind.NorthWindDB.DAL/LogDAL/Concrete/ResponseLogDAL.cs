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
    public class ResponseLogDAL:IResponseLogDAL
    {
        IDatabaseOperation databaseOperation;
        public ResponseLogDAL(IDatabaseOperation databaseOperation)
        {
            this.databaseOperation = databaseOperation;
        }

        public void Add(ResponseLog responseLog)
        {
            databaseOperation.Add(responseLog);
        }

        public ICollection<ResponseLog> GetResponseLogs()
        {

            DbDataReader dbDataReader = databaseOperation.GetEntities<ResponseLog>(out DbConnection dbConnection);

            return FillData(dbDataReader,dbConnection);
        }

        private static ICollection<ResponseLog> FillData(DbDataReader dbDataReader,DbConnection dbConnection)
        {
            ICollection<ResponseLog> responseLogs = new HashSet<ResponseLog>();

            while (dbDataReader.Read())
            {
                ResponseLog responseLog = new ResponseLog
                {
                    Id = Convert.ToInt32(dbDataReader["id"]),
                    CreateDate = Convert.ToDateTime(dbDataReader["CreateDate"]),
                    Path = dbDataReader["Path"].ToString()
                };
                responseLog.StatusCode = Convert.ToInt16(dbDataReader["StatusCode"]);

                responseLogs.Add(responseLog);
            }
            dbConnection.Close();
            return responseLogs;
        }
    }
}
