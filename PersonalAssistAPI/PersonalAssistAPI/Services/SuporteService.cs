using System.Collections.Generic;

public interface ISuporteService
{
	IEnumerable<Suporte> GetAll();
	Suporte GetById(int id);
	Suporte Create(Suporte suporte);
	void Update(Suporte suporte);
	void Delete(int id);
}

public class SuporteService : ISuporteService
{
	private readonly ISuporteRepository _repository;

	public SuporteService(ISuporteRepository repository)
	{
		_repository = repository;
	}

	public IEnumerable<Suporte> GetAll() => _repository.GetAll();

	public Suporte GetById(int id) => _repository.GetById(id);

	public Suporte Create(Suporte suporte) => _repository.Create(suporte);

	public void Update(Suporte suporte) => _repository.Update(suporte);

	public void Delete(int id) => _repository.Delete(id);
}
