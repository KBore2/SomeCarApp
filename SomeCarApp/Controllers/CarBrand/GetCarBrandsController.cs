using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SomeCarApp.Queries.GetCarBrands;

namespace SomeCarApp.Controllers
{
    [Route("api/")]
    [ApiController]
    public class GetCarBrandsController : ControllerBase
    {
        private readonly ILogger<GetCarBrandsController> _logger;
        private readonly IMediator _mediator;

        public GetCarBrandsController(ILogger<GetCarBrandsController> logger, IMediator mediator)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpGet]
        [Route("Car/GetCarBrands")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetCars()
        {
            _logger.LogInformation("Got request to get car brands");

            var query = new GetCarBrandsQuery();

            var response = await _mediator.Send(query);

            return Ok(response);
        }
    }
}
