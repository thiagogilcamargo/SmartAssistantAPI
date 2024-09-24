using System.Collections.Generic;

public interface ISuporteRepository
{
    IEnumerable<Suporte> GetAll();
    Suporte GetById(int id);
    Suporte Create(Suporte suporte);
    void Update(Suporte suporte);
    void Delete(int id);
}
