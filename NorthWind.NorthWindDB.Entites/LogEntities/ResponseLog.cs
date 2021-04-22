using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.NorthWindDB.Entites.LogEntities
{
    public class ResponseLog:IEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
      
        [MaxLength(100)]
        public string Path { get; set; }
        public short SatatusCode { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
