using System.Collections.Generic;

public interface IServicoService
{
    IEnumerable<Servico> GetAll();
    Servico GetById(int id);
    Servico Create(Servico servico);
    void Update(Servico servico);
    void Delete(int id);
}

public class ServicoService : IServicoService
{
    private readonly IServicoRepository _repository;

    public ServicoService(IServicoRepository repository)
    {
        _repository = repository;
    }

    public IEnumerable<Servico> GetAll() => _repository.GetAll();

    public Servico GetById(int id) => _repository.GetById(id);

    public Servico Create(Servico servico) => _repository.Create(servico);

    public void Update(Servico servico) => _repository.Update(servico);

    public void Delete(int id) => _repository.Delete(id);
}
