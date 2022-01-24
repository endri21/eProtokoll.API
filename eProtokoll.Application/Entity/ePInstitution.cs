using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eProtokoll.Application.Entity
{
    public class ePInstitution
    {
        [Key]
        public int id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
