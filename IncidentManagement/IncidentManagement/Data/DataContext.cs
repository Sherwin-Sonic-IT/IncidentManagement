using Microsoft.EntityFrameworkCore;
using SharedLibrary.Models;

namespace IncidentManagement.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Users_TBL> Users_TBL { get; set; }
        public DbSet<Incidents_TBL> Incidents_TBL { get; set; }
        public DbSet<Board_TBL> Board_TBL { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users_TBL>()
                .HasKey(pk => pk.User_ID);

            modelBuilder.Entity<Incidents_TBL>()
           .Property(i => i.Status)
           .HasColumnType("nvarchar(max)")  // Ensure it is nvarchar
           .HasDefaultValue("Pending")     // Set default value
           .IsRequired(false);
 
        }
    }
}

