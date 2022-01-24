
using System.ComponentModel.DataAnnotations.Schema;


namespace eProtokoll.Application.Entity
{
    public class ePUserRoles
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public int RoleId { get; set; }
        public bool IsDeleted { get; set; }
        [ForeignKey("RoleId")]
        public ePRole ePRole { get; set; }
        [ForeignKey("UserId")]
        public ePUser ePUser { get; set; }
    }
}
