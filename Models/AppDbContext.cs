using Microsoft.EntityFrameworkCore;

namespace w3d1.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            // Configure the Employee entity
            modelBuilder.Entity<Employee>()
                .ToTable("Employees");
        }
    }
} 