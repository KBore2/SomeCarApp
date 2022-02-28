using SomeCarApp.Domain.Entities;
using SomeCarApp.Domain.Interfaces;
using SomeCarApp.Domain.SeedWork;

namespace SomeCarApp.Domain.Services
{
    public class CarService : BaseService, ICarService
    {
        private readonly ICarRepository _carRepository;

        public CarService(ICarRepository carRepository, IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _carRepository = carRepository;
        }

        public async Task<Car> CreateCar(Car car)
        {
            var carEntity =  await _carRepository.AddAsync(car);

            await UnitOfWork.CommitAsync();

            return carEntity;
        }

        public async Task<List<Car>> GetCarsAsync()
        {
            return await _carRepository.ListAsync(c => true);
        }
    }
}
