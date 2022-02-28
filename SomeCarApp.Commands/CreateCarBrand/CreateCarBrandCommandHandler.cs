using MediatR;
using SomeCarApp.Domain.Entities;
using SomeCarApp.Domain.Services;

namespace SomeCarApp.Commands.CreateCarBrand
{
    public class CreateCarBrandCommandHandler : IRequestHandler<CreateCarBrandCommand, CarBrand>
    {
        private readonly ICarBrandService _carBrandService;

        public CreateCarBrandCommandHandler(ICarBrandService carBrandService)
        {
            _carBrandService = carBrandService;
        }

        public async Task<CarBrand> Handle(CreateCarBrandCommand request, CancellationToken cancellationToken)
        {
            return await _carBrandService.AddCarBrand(request.CarBrand);
        }
    }
}
