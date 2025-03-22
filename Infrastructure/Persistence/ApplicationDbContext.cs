using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Persistence
{
    public class ApplicationDbContext : IdentityDbContext<UserAuthentication>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var hasher = new PasswordHasher<UserAuthentication>();

            var user = new UserAuthentication
            {
                    Id = "1",
                    UserName = "admin",
                    Email = "rgise06@gmail.com",
                    NormalizedEmail = "rgise06@gmail.com",
                    EmailConfirmed = true
            };
             
            user.PasswordHash = hasher.HashPassword(user,"1234");

            modelBuilder.Entity<UserAuthentication>().HasData(user);
        } 
    }
}
