using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnitOfWorkPaging.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        int Complete();
        IProductRepository ProductRepository { get; set; }
        ICategoryRepository CategoryRepository { get; set; }
    }
}
