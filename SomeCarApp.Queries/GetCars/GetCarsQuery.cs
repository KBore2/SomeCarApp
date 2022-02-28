using MediatR;
using SomeCarApp.Domain.Entities;

namespace SomeCarApp.Queries.GetCars
{
    public class GetCarsQuery : IRequest<List<Car>>
    {
    }
}
