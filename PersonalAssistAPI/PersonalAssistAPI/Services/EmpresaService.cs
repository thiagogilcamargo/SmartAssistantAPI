using System.Collections.Generic;

public interface IEmpresaService
{
	IEnumerable<Empresa> GetAll();
	Empresa GetById(int id);
	Empresa Create(Empresa empresa);
	void Update(Empresa empresa);
	void Delete(int id);
}

public class EmpresaService : IEmpresaService
{
	private readonly IEmpresaRepository _repository;

	public EmpresaService(IEmpresaRepository repository)
	{
		_repository = repository;
	}

	public IEnumerable<Empresa> GetAll() => _repository.GetAll();

	public Empresa GetById(int id) => _repository.GetById(id);

	public Empresa Create(Empresa empresa) => _repository.Create(empresa);

	public void Update(Empresa empresa) => _repository.Update(empresa);

	public void Delete(int id) => _repository.Delete(id);
}
