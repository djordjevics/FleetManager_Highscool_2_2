using Microsoft.AspNetCore.Mvc;

namespace FleetManagerApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class VehiclesController : ControllerBase
{
    [HttpGet("GetAll")]
    [ProducesResponseType(200)]
    [ProducesResponseType(400, Type = typeof(string))] // if we have an error, we return a message containing the error reason
    public IActionResult GetAll()
    {
        return Ok(new int[]{ 1, 2, 3 });
    } 
}
