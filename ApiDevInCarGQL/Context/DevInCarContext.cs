using ApiDevInCarGQL.Models;
using ApiDevInCarGQL.Seeders;
using Microsoft.EntityFrameworkCore;

namespace ApiDevInCarGQL.Context
{
    public class DevInCarContext : DbContext
    {
        public DevInCarContext() {}

        public DevInCarContext(DbContextOptions<DevInCarContext> options) : base(options) {}

        public DbSet<Moto> Moto { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Van> Vans { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().HasData(CarSeed.CarSeeders);
            modelBuilder.Entity<Moto>().HasData(MotoSeed.MotoSeeders);
            modelBuilder.Entity<Van>().HasData(VanSeed.VansSeeders);
            modelBuilder.Entity<Customer>().HasData(CustomerSeed.CustomerSeeders);
        }
    }
}
