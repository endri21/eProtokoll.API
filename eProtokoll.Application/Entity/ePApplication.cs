using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eProtokoll.Application.Entity
{
    public class ePApplication
    {
        [Key]
        public int id { get; set; }
        public string Name { get; set; }
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public ePUser ePUser { get; set; }
        public int InstitutinId { get; set; }
        [ForeignKey("InstitutinId")]
        public ePInstitution ePInstitution { get; set; }
        public bool Deleted { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public int ApplicationTypeId { get; set; }
        [ForeignKey("ApplicationTypeId")]
        public ePApplicationType ePApplicationType { get; set; }
        public DateTime ApplicationReviewDate { get; set; }

    }
}
