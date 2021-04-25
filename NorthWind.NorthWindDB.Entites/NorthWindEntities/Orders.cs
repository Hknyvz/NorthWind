using System;
using System.Collections.Generic;

namespace NorthWind.NorthWindDB.Entites.NorthWindEntities
{
    public class Orders:BaseEntity,INorthWindEntity
    {
        public Orders()
        {
            Details = new HashSet<OrderDetails>();
        }
        public int Id { get; set; }
        public string CustomerId { get; set; }
        public int EmployeeId { get; set; }
        public string OrderDate { get; set; }
        public string RequiredDate { get; set; }
        public string ShippedDate { get; set; }
        public int? ShipVia { get; set; }
        public decimal? Freight { get; set; }
        public string ShipName { get; set; }
        public BaseAddress ShipAddress { get; set; }
        public ICollection<OrderDetails> Details { get; set; }
        
    }
}
