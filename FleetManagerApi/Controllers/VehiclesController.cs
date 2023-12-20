using Microsoft.AspNetCore.Mvc;
using Repositories.Models;
using Services;

namespace FleetManagerApi.Controllers;

[Route("[controller]")]
[ApiController]
public class VehiclesController : ControllerBase
{
    private IVehicleService _vehicleService;

    public VehiclesController(IVehicleService vehicleService) 
    { 
        _vehicleService = vehicleService; 
    }

    [HttpGet("GetAll")]
    [ProducesResponseType(200)]
    [ProducesResponseType(400, Type = typeof(string))] // if we have an error, we return a message containing the error reason
    public IActionResult GetAll()
    {
        return Ok(_vehicleService.GetAllVehicles());
    }

    [HttpGet("GetById/{id}")]
    [ProducesResponseType(200)]
    public IActionResult GetById(int id)
    {
        return Ok(new Vehicle { Id=id, Registration="dummy"});
    }

    [HttpPost("Create")]
    [ProducesResponseType(200)]
    public IActionResult Create(Vehicle v)
    {
        return Ok();
    }

    [HttpDelete("Delete/{id}")]
    [ProducesResponseType(200)]
    [ProducesResponseType(404, Type = typeof(string))]
    public IActionResult Delete(int id)
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

