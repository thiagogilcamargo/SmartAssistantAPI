using System.Collections.Generic;

public interface IEmpresaRepository
{
    IEnumerable<Empresa> GetAll();
    Empresa GetById(int id);
    Empresa Create(Empresa empresa);
    void Update(Empresa empresa);
    void Delete(int id);
}
