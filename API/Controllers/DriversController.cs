using Application.Features.Drivers.Commands.AddDriver;
using Application.Features.Drivers.Queries.GetAllDrivers;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[Route("api/Driver")]
public class DriversController : ControllerBase
{
    private readonly IMediator _mediator;

    public DriversController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("GetAllDrivers")]
    public async Task<IActionResult> GetAllDrivers()
    {
        var query = new GetAllDriversQuery();
        var result = await _mediator.Send(query);
        return Ok(result);
    }

    [HttpPost("AddDriver")]
    public async Task<IActionResult> AddDriver(AddDriverRequest request)
    {
        var command = new AddDriverCommand(request);
        var result = await _mediator.Send(command);
        return Ok(result);
    }
}