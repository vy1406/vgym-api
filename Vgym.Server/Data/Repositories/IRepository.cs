namespace Vgym.Server.Data.Repositories
{
    public interface IRepository<T> where T : class
    {
        Task Add(T entity);
        Task Delete(int id);
        Task<T> GetByName(string name);
        Task<IEnumerable<T>> GetAll();
        Task Update(T entity);
    }
}
