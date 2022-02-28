using SomeCarApp.Domain.SeedWork;

namespace SomeCarApp.Domain.Entities
{
    public record Car : BaseEntity
    {
        public Guid Id { get; set; }

        public string Model { get; set; }

        public Guid BrandId { get; set; }

        public CarBrand Brand { get; set; }
    }
}
