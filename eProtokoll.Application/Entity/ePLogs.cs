using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProtokoll.Application.Entity
{
    public class ePLogs
    {
        public int Id { get; set; }
        public string ErrorMessage { get; set; }
        public string Json { get; set; }
        public DateTime CreateAt { get; set; }
        public string InnerException { get; set; }
    }
}
