using Microsoft.AspNetCore.Http;
using NorthWind.NorthWindDB.BLL.LogManager.Abstract;
using NorthWind.NorthWindDB.DAL.LogDAL.Abstract;
using NorthWind.NorthWindDB.Entites.LogEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.NorthWindDB.BLL.LogManager.Concrete
{
    public class RequestLogBLL : IRequestLogBLL
    {
        IRequestLogDAL requestLogDAL;

        public RequestLogBLL(IRequestLogDAL requestLogDAL)
        {
            this.requestLogDAL = requestLogDAL;
        }
        
        public void Add(HttpRequest httpRequest, string body)
        {
            RequestLog requestLog = new RequestLog
            {
                Path = httpRequest.Path,
                Method = httpRequest.Method,
                CreateDate = DateTime.Now,
                SubQuery=httpRequest.QueryString.Value,
                Body=body
            };
            requestLogDAL.Add(requestLog);
        }

    }
}
