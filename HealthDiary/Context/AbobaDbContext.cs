using Microsoft.EntityFrameworkCore;
using HealthDiary.Entities;
namespace HealthDiary.Context

{
    public class AbobaDbContext : DbContext
    {
        public AbobaDbContext(DbContextOptions<AbobaDbContext> options) : base(options) 
        { 
        
        }

        public AbobaDbContext() { }
       /* protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Chinook");
            }
        }*/

        public DbSet<User> User { get; set; }
        public DbSet<PhysicalCharacteristics> PhysicalCharacteristics { get; set; }
        public DbSet<PhysicalProfile> PhysicalProfiles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasOne(e => e.PhysicalCharacteristics)
                .WithOne(ed => ed.User)
                .HasForeignKey<PhysicalCharacteristics>(ed => ed.UserId);

            modelBuilder.Entity<User>()
                .HasOne(e => e.PhysicalProfile)
                .WithOne(ed => ed.User)
                .HasForeignKey<PhysicalProfile>(ed => ed.UserID);

            base.OnModelCreating(modelBuilder);
        }
    }
}
