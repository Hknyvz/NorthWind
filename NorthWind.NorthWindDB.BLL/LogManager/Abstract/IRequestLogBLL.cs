using Microsoft.AspNetCore.Http;
using NorthWind.NorthWindDB.Entites.LogEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.NorthWindDB.BLL.LogManager.Abstract
{
    public interface IRequestLogBLL
    {
        void Add(HttpRequest httpRequest,string body);

        IEnumerable<RequestLog> GetRequestLogs();

    }
}
