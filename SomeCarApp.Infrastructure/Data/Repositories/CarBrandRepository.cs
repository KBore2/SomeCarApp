using SomeCarApp.Domain.Entities;
using SomeCarApp.Domain.Interfaces;
using SomeCarApp.Infrastructure.Repositories;

namespace SomeCarApp.Infrastructure.Data.Repositories
{
    public class CarBrandRepository : RepositoryBase<CarBrand>, ICarBrandRepository
    {
        public CarBrandRepository(CarAppContext dbContext) : base(dbContext)
        {
        }
    }
}
