using ApiDevInCarGQL.Models;
using ApiDevInCarGQL.Seeders;
using Microsoft.EntityFrameworkCore;

namespace ApiDevInCarGQL.Context
{
    public class DevInCarContext : DbContext
    {
        public DevInCarContext() {}

        public DevInCarContext(DbContextOptions<DevInCarContext> options) : base(options) {}

        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vehicle>().HasData(VehicleSeed.VehicleSeeders);
            modelBuilder.Entity<Customer>().HasData(CustomerSeed.CustomerSeeders);
        }
    }
}
