namespace Desafio_07.Interfaces;

public interface IDao<T> where T : class
{
    public Task<T> FindById(int id);
    public Task<IEnumerable<T>> FindAll();
    public Task Create(T data);
}