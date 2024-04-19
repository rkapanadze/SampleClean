using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[Route("api/Sample")]
public class SampleController : ControllerBase
{
    [HttpGet("SampleGet")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult> SampleGet(CancellationToken cancellationToken)
    {
        return Ok();
    }
}