using SomeCarApp.Domain.Entities;

namespace SomeCarApp.Domain.Services
{
    public interface ICarService
    {
        Task<Car> CreateCar(Car car);

        Task<List<Car>> GetCarsAsync();
    }
}
