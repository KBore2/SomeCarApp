using MediatR;
using SomeCarApp.Domain.Entities;

namespace SomeCarApp.Queries.GetCarBrands
{
    public class GetCarBrandsQuery : IRequest<List<string>>
    {
    }
}
