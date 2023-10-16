using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace RC2Demo.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Customer>().HasData(
               new Customer() { Id = 1, Name = "First Customer" },
               new Customer() { Id = 2, Name = "Second Customer" },
               new Customer() { Id = 3, Name = "Third Customer" });



        }

        public DbSet<Customer> Customers { get; set; }
    }
}
