//using Microsoft.EntityFrameworkCore;
//using SharedLibrary.Models;

//namespace IncidentManagement.Data
//{
//    public class DataContext : DbContext
//    {
//        public DataContext(DbContextOptions options) : base(options)
//        {
//        }
//        public DbSet<Users_TBL> Users_TBL { get; set; }
//        public DbSet<Incidents_TBL> Incidents_TBL { get; set; }
//        public DbSet<Board_TBL> Board_TBL { get; set; }
//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {
//            modelBuilder.Entity<Users_TBL>()
//                .HasKey(pk => pk.User_ID);

//            modelBuilder.Entity<Incidents_TBL>()
//           .Property(i => i.Status)
//           .HasColumnType("nvarchar(max)")  // Ensure it is nvarchar
//           .HasDefaultValue("Pending")     // Set default value
//           .IsRequired(false);

//            modelBuilder.Entity<StatusM>().HasData(
//            new StatusM { Id = 1, Status_Name = "Y", Status_Desc = "Active" },
//            new StatusM { Id = 2, Status_Name = "N", Status_Desc = "Inactive" }
//        );


//        }
//    }
//}


using Microsoft.EntityFrameworkCore;
using SharedLibrary.Models;

namespace IncidentManagement.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<UserM> UserM { get; set; }
        public DbSet<ApplicationM> ApplicationM { get; set; }
        public DbSet<RoleGroupDetailM> RoleGroupDetailM { get; set; }
        public DbSet<RoleGroupHeaderM> RoleGroupHeaderM { get; set; }
        public DbSet<SystemRoleM> SystemRoleM { get; set; }
        public DbSet<StatusM> StatusM { get; set; }

        public DbSet<Incidents_TBL> Incidents_TBL { get; set; }
        public DbSet<Board_TBL> Board_TBL { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserM>()
                .HasKey(pk => pk.UserId);

            modelBuilder.Entity<Incidents_TBL>()
           .Property(i => i.Status)
           .HasColumnType("nvarchar(max)")  // Ensure it is nvarchar
           .HasDefaultValue("Pending")     // Set default value
           .IsRequired(false);

            modelBuilder.Entity<StatusM>().HasData(
            new StatusM { Id = 1, Status_Name = "Y", Status_Desc = "Active" },
            new StatusM { Id = 2, Status_Name = "N", Status_Desc = "Inactive" }
        );


        }
    }
}


