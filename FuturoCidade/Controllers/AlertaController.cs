// Controllers/AlertaController.cs
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using futuroDacidade.Models;

[ApiController]
[Route("api/[controller]")]
public class AlertaController : ControllerBase
{
    private static List<Alerta> Alertas = new List<Alerta>();

    [HttpGet]
    public ActionResult<IEnumerable<Alerta>> Get()
    {
        return Ok(Alertas);
    }

    [HttpPost]
    public ActionResult<Alerta> Post([FromBody] Alerta alerta)
    {
        alerta.Id = Alertas.Count + 1;
        alerta.Data = DateTime.Now;
        Alertas.Add(alerta);
        return CreatedAtAction(nameof(Get), new { id = alerta.Id }, alerta);
    }
}
