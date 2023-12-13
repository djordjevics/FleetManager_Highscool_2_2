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
        return Ok(new int[] { 1, 2, 3 });
    }

    [HttpGet("GetById/{id}")]
    [ProducesResponseType(200)]
    public IActionResult GetById(int id)
    {
        return Ok(id);
    }

    [HttpPost("Create")]
    [ProducesResponseType(200)]
    public IActionResult Create(Temp obj)
    {
        obj.id += 3;
        obj.name += "asd";
        return Ok(obj);
    }
}
public class Temp { public int id { get; set; } public string name { get; set; } }
