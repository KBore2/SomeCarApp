using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SomeCarApp.Domain.Entities;

namespace SomeCarApp.Infrastructure.Data.EntityConfiguration
{
    public class BrandEntityConfiguration : IEntityTypeConfiguration<CarBrand>
    {
        public void Configure(EntityTypeBuilder<CarBrand> builder)
        {
            builder
             .HasKey(x => x.Id);

            builder
                .HasMany(c => c.Cars)
                .WithOne(b => b.Brand);
        }
    }
}
