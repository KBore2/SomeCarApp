using SomeCarApp.Domain.Entities;
using SomeCarApp.Domain.Interfaces;
using SomeCarApp.Infrastructure.Repositories;

namespace SomeCarApp.Infrastructure.Data.Repositories
{
    public class CarRepository : RepositoryBase<Car>, ICarRepository
    {
        public CarRepository(CarAppContext dbContext) : base(dbContext)
        {
        }
    }
}
