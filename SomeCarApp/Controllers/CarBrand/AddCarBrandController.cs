using MediatR;
using Microsoft.AspNetCore.Mvc;
using SomeCarApp.Commands.CreateCarBrand;
using SomeCarApp.Domain.Entities;

namespace SomeCarApp.Controllers
{
    [Route("api/")]
    [ApiController]
    public class AddCarBrandController : ControllerBase
    {
        private readonly ILogger<AddCarBrandController> _logger;
        private readonly IMediator _mediator;

        public AddCarBrandController(ILogger<AddCarBrandController> logger, IMediator mediator)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpPost]
        [Route("CarBrand/Create")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> CreateCarBrand(CarBrand carBrand)
        {
            _logger.LogInformation("Got request to create car brand {@CarBrand}", carBrand);

            var command = new CreateCarBrandCommand()
            {
                CarBrand = carBrand
            };

            var response = await _mediator.Send(command);

            return Ok(response);
        }
    }
}
