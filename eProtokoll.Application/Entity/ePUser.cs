
using System.ComponentModel.DataAnnotations;


namespace eProtokoll.Application.Entity
{
    public class ePUser
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Token { get; set; }
        public byte[] Photo { get; set; }
        public string PhotoName { get; set; }
        public string PhotoExtension { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
    }
}
