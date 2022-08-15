using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyVitals.API.DataContext.Repositories
{
    public interface IRepository<T,T2> where T : class
    {
        Task<List<T>> GetAll();
        Task<T> Get(T2 id);
        Task<int> Add(T entity);
        Task<int> Update(T entity);
        Task<bool> Delete(T2 id);
    }
}
