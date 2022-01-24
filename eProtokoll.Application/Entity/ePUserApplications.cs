using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace eProtokoll.Application.Entity
{
    public class ePUserApplications
    {
        [Key]
        public int id { get; set; }
        public int From { get; set; }
        public int To { get; set; }
        public DateTime AprovedAt { get; set; }
        public int ApplicationId { get; set; }
        [ForeignKey("ApplicationId")]
        public ePApplication ePApplication { get; set; }
        public string Status { get; set; }
        public bool IsDeleted { get; set; }
        public string Comment { get; set; }
        public bool Refused { get; set; }
        public bool Aproved { get; set; }
        public bool Finished { get; set; }
    }
}
