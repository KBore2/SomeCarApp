using SomeCarApp.Domain.Entities;
using SomeCarApp.Domain.Interfaces;
using SomeCarApp.Domain.SeedWork;

namespace SomeCarApp.Domain.Services
{
    public class CarBrandService : BaseService, ICarBrandService
    {
        private readonly ICarBrandRepository _carBrandRepository;

        public CarBrandService(ICarBrandRepository carBrandRepository, IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _carBrandRepository = carBrandRepository;
        }

        public async Task<CarBrand> AddCarBrand(CarBrand carBrand)
        {
            var carBrands = await _carBrandRepository.AddAsync(carBrand);

            await UnitOfWork.CommitAsync();

            return carBrands;
        }

        public async Task<List<CarBrand>> GetCarBrands()
        {
            return await _carBrandRepository.ListAsync();
        }
    }
}
