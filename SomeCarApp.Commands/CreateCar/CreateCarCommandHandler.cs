using MediatR;
using SomeCarApp.Domain.Entities;
using SomeCarApp.Domain.Services;

namespace SomeCarApp.Commands.CreateCar
{
    public class CreateCarCommandHandler : IRequestHandler<CreateCarCommand, Car>
    {
        private readonly ICarService _carService;

        public CreateCarCommandHandler(ICarService carService)
        {
            _carService = carService;
        }

        public async Task<Car> Handle(CreateCarCommand request, CancellationToken cancellationToken)
        {
            var response = await _carService.CreateCar(request.Car);

            return response;
        }
    }
}
