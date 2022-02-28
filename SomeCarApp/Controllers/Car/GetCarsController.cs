using MediatR;
using Microsoft.AspNetCore.Mvc;
using SomeCarApp.Queries.GetCars;

namespace SomeCarApp.Controllers
{
    [Route("api/")]
    [ApiController]
    public class GetCarsController : ControllerBase
    {
        private readonly ILogger<GetCarsController> _logger;
        private readonly IMediator _mediator;

        public GetCarsController(ILogger<GetCarsController> logger, IMediator mediator)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpGet]
        [Route("Car/GetCars")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetCars()
        {
            _logger.LogInformation("Got request to get cars");

            var query = new GetCarsQuery();

            var response = await _mediator.Send(query);

            return Ok(response);
        }
    }
}
