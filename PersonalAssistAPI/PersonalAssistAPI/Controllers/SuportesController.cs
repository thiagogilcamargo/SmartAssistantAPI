using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class SuportesController : ControllerBase
{
    private readonly ISuporteService _suporteService;

    public SuportesController(ISuporteService suporteService)
    {
        _suporteService = suporteService;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var suportes = _suporteService.GetAll();
        return Ok(suportes);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var suporte = _suporteService.GetById(id);
        if (suporte == null) return NotFound();
        return Ok(suporte);
    }

    [HttpPost]
    public IActionResult Create([FromBody] Suporte suporte)
    {
        var createdSuporte = _suporteService.Create(suporte);
        return CreatedAtAction(nameof(GetById), new { id = createdSuporte.Id }, createdSuporte);
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, [FromBody] Suporte suporte)
    {
        if (id != suporte.Id) return BadRequest();
        _suporteService.Update(suporte);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        _suporteService.Delete(id);
        return NoContent();
    }
}
