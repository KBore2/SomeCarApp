using MediatR;
using Microsoft.AspNetCore.Mvc;
using SomeCarApp.Commands.CreateCar;
using SomeCarApp.Domain.Entities;

namespace SomeCarApp.Controllers
{
    [Route("api/")]
    [ApiController]
    public class CreateCarController : ControllerBase
    {
        private readonly ILogger<CreateCarController> _logger;
        private readonly IMediator _mediator;

        public CreateCarController(ILogger<CreateCarController> logger, IMediator mediator)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpPost]
        [Route("Car/Create")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> CreateCar(Car car)
        {
            _logger.LogInformation("Got request to create car {@Car}", car);

            var command = new CreateCarCommand()
            {
                Car = car
            };

            var response = await _mediator.Send(command);

            return Ok(response);
        }
    }
}
