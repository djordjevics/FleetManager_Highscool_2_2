using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
            return Ok(new int[] { 1, 2, 3 });
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