

using Microsoft.EntityFrameworkCore;

namespace UroTaxi.Entities
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=LAPTOP-SIJ9TPCE;Initial Catalog=Taxeei;Integrated Security=True;TrustServerCertificate=True");
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<CarModel> CarModels { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<CarType> CarTypes { get; set; }
        public DbSet<City> City { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }

    }
}
