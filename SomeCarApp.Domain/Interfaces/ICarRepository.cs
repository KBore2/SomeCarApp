using SomeCarApp.Domain.Entities;
using SomeCarApp.Domain.SeedWork;

namespace SomeCarApp.Domain.Interfaces
{
    public interface ICarRepository : IAsyncRepository<Car>
    {
    }
}
