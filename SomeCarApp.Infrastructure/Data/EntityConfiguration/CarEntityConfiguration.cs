using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SomeCarApp.Domain.Entities;

namespace SomeCarApp.Infrastructure.Data.EntityConfiguration
{
    public class CarEntityConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
                .HasOne(b => b.Brand)
                .WithMany(c => c.Cars)
                .HasForeignKey(f => f.BrandId);
        }
    }
}
