using Microsoft.EntityFrameworkCore;
using SomeCarApp.Domain.Entities;
using SomeCarApp.Infrastructure.Data.EntityConfiguration;

namespace SomeCarApp.Infrastructure
{
    public class CarAppContext : DbContext
    {
        public CarAppContext()
        {

        }

        public CarAppContext(DbContextOptions<CarAppContext> options) : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; }

        public DbSet<CarBrand> Brands { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CarEntityConfiguration).Assembly);
        }
    }
}
