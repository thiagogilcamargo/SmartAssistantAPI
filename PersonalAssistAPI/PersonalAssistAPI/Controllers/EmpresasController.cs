using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class EmpresasController : ControllerBase
{
	private readonly IEmpresaService _empresaService;

	public EmpresasController(IEmpresaService empresaService)
	{
		_empresaService = empresaService;
	}

	[HttpGet]
	public IActionResult GetAll()
	{
		var empresas = _empresaService.GetAll();
		return Ok(empresas);
	}

	[HttpGet("{id}")]
	public IActionResult GetById(int id)
	{
		var empresa = _empresaService.GetById(id);
		if (empresa == null) return NotFound();
		return Ok(empresa);
	}

	[HttpPost]
	public IActionResult Create([FromBody] Empresa empresa)
	{
		var createdEmpresa = _empresaService.Create(empresa);
		return CreatedAtAction(nameof(GetById), new { id = createdEmpresa.Id }, createdEmpresa);
	}

	[HttpPut("{id}")]
	public IActionResult Update(int id, [FromBody] Empresa empresa)
	{
		if (id != empresa.Id) return BadRequest();
		_empresaService.Update(empresa);
		return NoContent();
	}

	[HttpDelete("{id}")]
	public IActionResult Delete(int id)
	{
		_empresaService.Delete(id);
		return NoContent();
	}
}
