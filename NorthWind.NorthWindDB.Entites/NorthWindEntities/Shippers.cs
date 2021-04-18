using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.NorthWindDB.Entites.NorthWindEntities
{
    public class Shippers:BaseEntity
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }

    }
}
