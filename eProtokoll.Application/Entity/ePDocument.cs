using System;

namespace eProtokoll.Application.Entity
{
    public class ePDocument
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte[] Content { get; set; }
        public string Base64 { get; set; }
        public string Extension { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public bool Deleted { get; set; }
    }
}
