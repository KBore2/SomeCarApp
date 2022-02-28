using SomeCarApp.Domain.SeedWork;

namespace SomeCarApp.Domain.Entities
{
    public record CarBrand : BaseEntity
    {
        public Guid Id { get; set; }

        public string BrandName { get; set; }

        public ICollection<Car> Cars { get; set; }   
    }
}
