using Microsoft.AspNetCore.Mvc;

namespace FleetManagerApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class VehiclesController : ControllerBase
{
    public IActionResult GetAll()
    {
        return Ok(new int[]{ 1, 2, 3 });
    } 
}
