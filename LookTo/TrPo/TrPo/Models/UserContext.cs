using Microsoft.EntityFrameworkCore;

namespace TrPo.Models
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Translation> Translations { get; set; }
        public DbSet<BroadcastList> UsersBroadcasts { get; set; }
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {
            //Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            string adminRoleName = "admin";
            string mentorRoleName = "mentor";
            string userRoleName = "user";

            Role adminRole = new Role { Id = 1, Name = adminRoleName };
            Role userRole = new Role { Id = 2, Name = userRoleName };
            Role mentorRole = new Role { Id = 3, Name = mentorRoleName };

            modelBuilder.Entity<Role>().HasData(new Role[] { adminRole, userRole, mentorRole });
            base.OnModelCreating(modelBuilder);
        }
    }
}
