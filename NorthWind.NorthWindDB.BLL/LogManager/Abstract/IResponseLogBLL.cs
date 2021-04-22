using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.NorthWindDB.BLL.LogManager.Abstract
{
    public interface IResponseLogBLL
    {
        void Add(HttpResponse httpResponse);
    }
}
