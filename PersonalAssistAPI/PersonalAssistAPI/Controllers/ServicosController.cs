using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class ServicosController : ControllerBase
{
    private readonly IServicoService _servicoService;

    public ServicosController(IServicoService servicoService)
    {
        _servicoService = servicoService;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var servicos = _servicoService.GetAll();
        return Ok(servicos);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var servico = _servicoService.GetById(id);
        if (servico == null) return NotFound();
        return Ok(servico);
    }

    [HttpPost]
    public IActionResult Create([FromBody] Servico servico)
    {
        var createdServico = _servicoService.Create(servico);
        return CreatedAtAction(nameof(GetById), new { id = createdServico.Id }, createdServico);
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, [FromBody] Servico servico)
    {
        if (id != servico.Id) return BadRequest();
        _servicoService.Update(servico);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        _servicoService.Delete(id);
        return NoContent();
    }
}
