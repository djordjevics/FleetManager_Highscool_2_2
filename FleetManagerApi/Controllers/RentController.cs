using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repositories.Models;

namespace FleetManagerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentController : ControllerBase
    {

        [HttpGet("GetAll")]
        [ProducesResponseType(200)]

        public IActionResult GetAll()
        {
            return Ok(new List<Rent>
            {
                new Rent { Id = 1,
                           DateFrom= DateTime.Now ,
                           DateTo = new (2023, 12, 30),
                           RentedVehicle = new Vehicle {Registration = "NS123NS" }
                },
                new Rent { Id = 2,
                           DateFrom= DateTime.Now ,
                           DateTo= new (2024, 2, 23),
                           RentedVehicle = new Vehicle {Registration = "NS234BM" } } 
            });
        }

        [HttpGet("GetByID/{ID}")]
        [ProducesResponseType(200)]
        public IActionResult Get(int id)
        {
            return Ok(id);
        }

        [HttpGet("GetByVehicleID/{vehicleid}")]
        [ProducesResponseType(200)]
        public IActionResult GetByVehicleID(int vehicleid)
        {
            return Ok(vehicleid);
        }

        [HttpPost("Create")]
        [ProducesResponseType(200)]
        public IActionResult Create(Temp3 obj)
        {
            obj.id += 1;
            obj.rentId += 1;
            return Ok(obj);
        }

        [HttpPut("Update")]
        [ProducesResponseType(200)]
        public IActionResult Update(Temp3 obj)
        {
            return Ok();
        }

    }
}

public class Temp3
{ 
    public int id { get; set; }
    public int rentId { get; set; } 
}