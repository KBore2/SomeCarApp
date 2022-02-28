using SomeCarApp.Domain.Entities;

namespace SomeCarApp.Domain.Services
{
    public interface ICarBrandService
    {
        Task<CarBrand> AddCarBrand(CarBrand carBrand);

        Task<List<CarBrand>> GetCarBrands();
    }
}
