

using System.Collections.Generic;

namespace UnitOfWorkPaging.Interfaces
{
    public interface IRepository<T> where T:class
    {
        T Get(int id);
        IEnumerable<T> List();
        T Add(T entity);
        T Update(T entity);
        T Delete(int id);
    }
}
