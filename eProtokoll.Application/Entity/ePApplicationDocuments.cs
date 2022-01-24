using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eProtokoll.Application.Entity
{
    public class ePApplicationDocuments
    {
        public int Id { get; set; }

        public int DocumentId { get; set; }
        public int ApplicationId { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreateBy { get; set; }
        [ForeignKey("ApplicationId")]
        public ePApplication ePApplication { get; set; }
        [ForeignKey("DocumentId")]
        public ePDocument ePDocument { get; set; }
        public DateTime ModifiedAt { get; set; }
        public bool Deleted { get; set; }
    }
}
