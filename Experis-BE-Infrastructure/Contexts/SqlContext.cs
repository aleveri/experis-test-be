using Experis_BE_Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Experis_BE_Infrastructure.Contexts
{
    public class SqlContext : DbContext
    {
        public string _sqlConnectionString;

        public DbSet<Student> Student { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasKey(x => x.Id);
            modelBuilder.Entity<Student>().HasIndex(x => x.UserName).IsUnique();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_sqlConnectionString);
        }
    }
}
