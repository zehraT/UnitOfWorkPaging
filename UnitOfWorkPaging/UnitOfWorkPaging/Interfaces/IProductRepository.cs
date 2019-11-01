
using System.Collections.Generic;
using UnitOfWorkPaging.Models;

namespace UnitOfWorkPaging.Interfaces
{
    public interface IProductRepository : IRepository<Product>
    {
        IEnumerable<Product> GetByCategoryId(int id);
    }
}
