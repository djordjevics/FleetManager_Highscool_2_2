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

        [HttpPost("Create")]
        [ProducesResponseType(200)]

        public IActionResult Create(Temp obj)
        {
            obj.id += 3;
            obj.name += "asd";
            return Ok(obj);
        }
    }
}

public class Temp { public int id { get; set; } public string name { get; set; } }