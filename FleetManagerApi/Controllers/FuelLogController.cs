using Microsoft.AspNetCore.Mvc;

namespace FleetManagerApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class FuelLogController : ControllerBase
{
    List<Temp2> temp = new List<Temp2>()
    {
        new Temp2{id = 6, age = 5},
        new Temp2{id = 7, age = 6}
    };

    [HttpGet("GetAll")]
    [ProducesResponseType(200)]
    public IActionResult GetAll()
    {
        return Ok();
    }

    [HttpGet("GetById/{id}")]
    [ProducesResponseType(200)]

    public IActionResult GetByID(int id) 
    {
        return Ok(id);
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

    public IActionResult Update(Temp2 obj)
    {
        return Ok();
    }
}

public class Temp2 { public int id { get; set; } public int age { get; set; } }