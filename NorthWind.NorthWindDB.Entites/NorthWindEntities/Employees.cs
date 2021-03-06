using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.NorthWindDB.Entites.NorthWindEntities
{
    public class Employess:BaseEntity,INorthWindEntity
    {
        public Employess()
        {
            TerritoryIds = new List<int>(Id);
        }
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Title { get; set; }
        public string TitleOfCourtesy { get; set; }
        public string BirthDate { get; set; }
        public string HireDate { get; set; }
        public Address Address { get; set; }
        public string Notes { get; set; }
        public string ReportsTo { get; set; }
        public ICollection<int> TerritoryIds { get; set; }
    }
}
