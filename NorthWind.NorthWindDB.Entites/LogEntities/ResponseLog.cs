using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.NorthWindDB.Entites.LogEntities
{
    public class ResponseLog
    {
        public int Id { get; set; }
        public string ClientType { get; set; }
        public string Path { get; set; }
        public short SatatusCode { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
