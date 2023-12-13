using Microsoft.AspNetCore.Mvc;

namespace FleetManagerApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class VehiclesController : ControllerBase
{
    List<Temp> lista = new()
    {
        new Temp { id = 3, name = "asd" },
        new Temp { id = 4, name = "ss" },
        new Temp { id = 5, name = "assd" },
        new Temp { id = 6, name = "asdsas" },
        new Temp { id = 7, name = "asdassss" }
    };

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

    [HttpDelete("Delete/{id}")]
    [ProducesResponseType(200)]
    [ProducesResponseType(404, Type = typeof(string))]
    public IActionResult Delete(int id)
    {
        var obj = lista.FirstOrDefault(x => x.id == id);
        lista.Remove(obj);
        if (obj == null)
            return NotFound("Object doesn't exist.");
        else
            return Ok(obj);
    }

    [HttpPut("Update")]
    [ProducesResponseType(200)]
    public IActionResult Update(Temp obj)
    {
        return Ok();
    }
}
public class Temp { public int id { get; set; } public string name { get; set; } }
