using MediatR;
using SomeCarApp.Domain.Entities;

namespace SomeCarApp.Commands.CreateCarBrand
{
    public class CreateCarBrandCommand : IRequest<CarBrand>
    {
        public CarBrand CarBrand { get; set; }
    }
}
