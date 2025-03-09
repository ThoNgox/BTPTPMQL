using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MvcMovie.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Person> Persons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().HasData(
                new Person { PersonId = "P001", FullName = "Nguyen Van A", Address = "Ha Noi", Email = "a@example.com" },
                new Person { PersonId = "P002", FullName = "Tran Thi B", Address = "TP.HCM", Email = "b@example.com" }
            );
        }
    }
}