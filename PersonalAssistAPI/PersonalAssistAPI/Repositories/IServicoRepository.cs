using System.Collections.Generic;

public interface IServicoRepository
{
    IEnumerable<Servico> GetAll();
    Servico GetById(int id);
    Servico Create(Servico servico);
    void Update(Servico servico);
    void Delete(int id);
}
