using MediatR;
using SomeCarApp.Domain.Services;

namespace SomeCarApp.Queries.GetCarBrands
{
    public class GetCarBrandsQueryHandler : IRequestHandler<GetCarBrandsQuery, List<string>>
    {
        private readonly ICarBrandService _carBrandService;

        public GetCarBrandsQueryHandler(ICarBrandService carBrandService)
        {
            _carBrandService = carBrandService;
        }

        public async Task<List<string>> Handle(GetCarBrandsQuery request, CancellationToken cancellationToken)
        {
            var carBrands = await _carBrandService.GetCarBrands();

            var response = carBrands.Select(e => e.BrandName).ToList();

            return response;
        }
    }
}
