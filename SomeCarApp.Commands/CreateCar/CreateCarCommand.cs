using MediatR;
using SomeCarApp.Domain.Entities;

namespace SomeCarApp.Commands.CreateCar
{
    public class CreateCarCommand : IRequest<Car>
    {
        public Car Car { get; set; } 
    }
}
