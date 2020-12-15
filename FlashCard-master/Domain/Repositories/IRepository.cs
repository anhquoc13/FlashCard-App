using System.Collections.Generic;

namespace Domain.Repositories
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        T GetBy(int id);
        void Add(T entity);
        void Update(T entity);
        void Remove(T entity);
        int Count();
    }
}