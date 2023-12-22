using Microsoft.AspNetCore.Mvc;
using Repositories.Models;
using Services;

namespace FleetManagerApi.Controllers;

[Route("[controller]")]
[ApiController]
public class FuelLogController : ControllerBase
{
    private IFuelLogService _fuelLogService;

    public FuelLogController(IFuelLogService fuelLog)
    {
        _fuelLogService = fuelLog;
    }

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
        return Ok(_fuelLogService.GetById(id));
    }

    [HttpGet("GetByVehicleId/{id}")]
    [ProducesResponseType(200)]

    public IActionResult GetByVehicleID(int id) 
    {
        return Ok(_fuelLogService.GetByVehicleID(id));
    }

    [HttpPost("Create")]
    [ProducesResponseType(200)]

    public IActionResult Create(FuelLog fuelLog)
    {
        return Ok(_fuelLogService.Create(fuelLog));
    }

    [HttpPut("Update")]
    [ProducesResponseType(200)]

    public IActionResult Update(FuelLog fuelLog)
    {
        return Ok(_fuelLogService.Update(fuelLog));
    }
}
