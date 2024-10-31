// Controllers/SensorController.cs
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using futuroDacidade.Models; 


[ApiController]
[Route("api/[controller]")]
public class SensorController : ControllerBase
{
    private static List<Sensor> Sensores = new List<Sensor>();

    [HttpGet]
    public ActionResult<IEnumerable<Sensor>> Get()
    {
        return Ok(Sensores);
    }

    [HttpPost]
    public ActionResult<Sensor> Post([FromBody] Sensor sensor)
    {
        sensor.Id = Sensores.Count + 1;
        Sensores.Add(sensor);
        return CreatedAtAction(nameof(Get), new { id = sensor.Id }, sensor);
    }
}
