using MediatR;
using SomeCarApp.Domain.Entities;
using SomeCarApp.Domain.Services;

namespace SomeCarApp.Queries.GetCars
{
    public class GetCarsQueryHandler : IRequestHandler<GetCarsQuery, List<Car>>
    {
        private readonly ICarService _carService;

        public GetCarsQueryHandler(ICarService carService)
        {
            _carService = carService;
        }

        public async Task<List<Car>> Handle(GetCarsQuery request, CancellationToken cancellationToken)
        {
            var cars = await _carService.GetCarsAsync();

            return cars;
        }
    }
}
