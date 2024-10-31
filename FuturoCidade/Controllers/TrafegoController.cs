// Controllers/TrafegoController.cs
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using futuroDacidade.Models;


[ApiController]
[Route("api/[controller]")]
public class TrafegoController : ControllerBase
{
    private static List<Trafego> TrafegoDados = new List<Trafego>();

    [HttpGet]
    public ActionResult<IEnumerable<Trafego>> Get()
    {
        return Ok(TrafegoDados);
    }

    [HttpPost]
    public ActionResult<Trafego> Post([FromBody] Trafego trafego)
    {
        trafego.Id = TrafegoDados.Count + 1;
        TrafegoDados.Add(trafego);
        return CreatedAtAction(nameof(Get), new { id = trafego.Id }, trafego);
    }
}
