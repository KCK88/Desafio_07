using Desafio_07.Entities;
using Desafio_07.Interfaces;

namespace Desafio_07.Dao;

public class CursoDao : IDao<Curso>
{
    public Task<Curso> FindById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Curso>> FindAll()
    {
        throw new NotImplementedException();
    }

    public Task Create(Curso data)
    {
        throw new NotImplementedException();
    }
}