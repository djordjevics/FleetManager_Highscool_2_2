using Microsoft.AspNetCore.Mvc;
using Repositories.Models;
using Services;

namespace FleetManagerApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RentController : ControllerBase
    {
        private IRentService _rentService;

        public RentController (IRentService rentService) 
        {  
            _rentService = rentService; 
        }

        [HttpGet("GetAll")]
        [ProducesResponseType(200)]

        public IActionResult GetAll()
        {
            return Ok(_rentService.GetAllRents());
        }

        [HttpGet("GetByID/{ID}")]
        [ProducesResponseType(200)]
        public IActionResult Get(int id)
        {
            return Ok(_rentService.GetRent(id));
        }

        [HttpGet("GetByVehicleID/{vehicleid}")]
        [ProducesResponseType(200)]
        public IActionResult GetByVehicleID(int vehicleid)
        {
            return Ok(_rentService.GetRentByVehicleId(vehicleid));
        }

        [HttpPost("Create")]
        [ProducesResponseType(200)]
        public IActionResult Create(Rent obj)
        { 
            return Ok(_rentService.Create(obj));
        }

        [HttpPut("Update")]
        [ProducesResponseType(200)]
        public IActionResult Update(Rent obj)
        {
            return Ok(_rentService.Update(obj));
        }

    }
}
