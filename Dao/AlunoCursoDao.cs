using Desafio_07.Entities;
using Desafio_07.Interfaces;

namespace Desafio_07.Dao;

public class AlunoCursoDao : IDao<AlunoCurso>
{
    public Task<AlunoCurso> FindById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<AlunoCurso>> FindAll()
    {
        throw new NotImplementedException();
    }

    public Task Create(AlunoCurso data)
    {
        throw new NotImplementedException();
    }
}