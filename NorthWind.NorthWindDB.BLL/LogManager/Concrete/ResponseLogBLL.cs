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
    public class ResponseLogBLL:IResponseLogBLL
    {
        IResponseLogDAL responseLogDAL;
        public ResponseLogBLL(IResponseLogDAL responseLogDAL)
        {
            this.responseLogDAL = responseLogDAL;
        }

        public void Add(HttpResponse httpResponse)
        {
            ResponseLog responseLog = new ResponseLog()
            {
                Path = httpResponse.HttpContext.Request.Path.ToString(),
                CreateDate = DateTime.Now,
                StatusCode = Convert.ToInt16(httpResponse.StatusCode),
            };

            responseLogDAL.Add(responseLog);
        }

        public ICollection<ResponseLog> GetResponseLogs()
        {
            return responseLogDAL.GetResponseLogs();
        }
    }
}
