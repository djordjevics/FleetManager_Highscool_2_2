using Microsoft.AspNetCore.Mvc;
using Repositories.Models;

namespace FleetManagerApi.Controllers;

[Route("[controller]")]
[ApiController]
public class FuelLogController : ControllerBase
{

    [HttpGet("GetAll")]
    [ProducesResponseType(200)]
    public IActionResult GetAll()
    {
        return Ok(new List<FuelLog>
        {
            new FuelLog(1, new Vehicle() { Registration="ns118ux" }, 30),
            new FuelLog(2, new Vehicle() { Registration="ns333us" }, 45)
        }) ;
    }

    [HttpGet("GetById/{id}")]
    [ProducesResponseType(200)]

    public IActionResult GetByID(int id) 
    {
        return Ok(new FuelLog(id, new Vehicle { Registration = "random" }, 99));
    }

    [HttpGet("GetByVehicleId/{id}")]
    [ProducesResponseType(200)]

    public IActionResult GetByVehicleID(int id) 
    {
        return Ok(id);
    }

    [HttpPost("Create")]
    [ProducesResponseType(200)]

    public IActionResult Create()
    {
        return Ok();
    }

    [HttpPut("Update")]
    [ProducesResponseType(200)]

    public IActionResult Update()
    {
        return Ok();
    }
}
