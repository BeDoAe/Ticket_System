using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Ticket_System.Models
{
    public class Context : IdentityDbContext<ApplicationUser>
    {
       public Context(DbContextOptions<Context> options) : base(options) { }

        public DbSet<Ticket> Tickets { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Admin User
            var adminUser = new ApplicationUser
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "admin",
                Email = "admin@example.com",
                FirstName = "Admin",
                LastName = "User",
                PhoneNumber = "123-456-7890"
            };

            var hasher = new PasswordHasher<ApplicationUser>();
            adminUser.PasswordHash = hasher.HashPassword(adminUser, "Admin@123");

            modelBuilder.Entity<ApplicationUser>().HasData(adminUser);

            // Regular Users
            for (int i = 1; i <= 9; i++)
            {
                var user = new ApplicationUser
                {
                    Id = Guid.NewGuid().ToString(),
                    UserName = $"user{i}",
                    Email = $"user{i}@example.com",
                    FirstName = $"First{i}",
                    LastName = $"Last{i}",
                    PhoneNumber = $"123-456-78{i:D2}"
                };

                user.PasswordHash = hasher.HashPassword(user, "Password@123");

                modelBuilder.Entity<ApplicationUser>().HasData(user);
            }
        }
    }
}