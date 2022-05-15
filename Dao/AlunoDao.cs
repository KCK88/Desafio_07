using Desafio_07.Entities;
using Desafio_07.Interfaces;

namespace Desafio_07.Dao;

public class AlunoDao : IDao<Aluno>
{
    public Task<Aluno> FindById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Aluno>> FindAll()
    {
        throw new NotImplementedException();
    }

    public Task Create(Aluno data)
    {
        throw new NotImplementedException();
    }
}