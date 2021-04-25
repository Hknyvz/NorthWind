using NorthWind.NorthWindDB.Entites.LogEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.NorthWindDB.DAL.LogDAL.Abstract
{
    public interface IRequestLogDAL
    {
        void Add(RequestLog requestLog);

        ICollection<RequestLog> GetRequestLogs();
    }
}
