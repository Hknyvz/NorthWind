using NorthWind.NorthWindDB.Entites.LogEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.NorthWindDB.DAL.LogDAL.Abstract
{
    public interface IResponseLogDAL
    {
        void Add(ResponseLog responseLog);
        ICollection<ResponseLog> GetResponseLogs();
    }
}
