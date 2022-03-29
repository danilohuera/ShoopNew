using Microsoft.EntityFrameworkCore;
using ShoopNew.Data.Entities;

namespace ShoopNew.Data.Entities
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)   
        {

        }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasIndex(c =>c.Name).IsUnique();
        }
    }
}
