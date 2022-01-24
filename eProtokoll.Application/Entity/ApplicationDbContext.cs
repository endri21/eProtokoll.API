using Microsoft.EntityFrameworkCore;

namespace eProtokoll.Application.Entity
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
         : base(options)
        {
        }
        public DbSet<ePUser> ePUsers { get; set; }
        public DbSet<ePUserRoles> ePUserRoles { get; set; }
        public DbSet<ePRole> ePRoles { get; set; }
        public DbSet<ePLogs> ePLogs { get; set; }
        public DbSet<ePApplication> ePAplication { get; set; }
        public DbSet<ePInstitution> ePInstitution { get; set; }
        public DbSet<ePApplicationDocuments> ePApplicationDocuments { get; set; }
        public DbSet<ePDocument> ePDocument { get; set; }
        public DbSet<ePUserApplications> ePUserApplications { get; set; }
        public DbSet<ePApplicationType> ePApplicationType { get; set; }
        public DbSet<ePUserPersonalInfo> ePUserPersonalInfo { get; set; }
        public DbSet<ePNotification> ePNotifications { get; set; }
        //protected override void OnModelCreating(ModelBuilder builder)
        //{


        //    base.OnModelCreating(builder);
        //}
    }
}
