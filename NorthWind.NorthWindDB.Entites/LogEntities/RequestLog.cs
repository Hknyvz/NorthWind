using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.NorthWindDB.Entites.LogEntities
{
    public class RequestLog
    {
        public int Id { get; set; }
        public string ClientType { get; set; }
        public string Path { get; set; }
        public string Method { get; set; }
        public string Body { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
