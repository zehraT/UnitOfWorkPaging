using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnitOfWorkPaging.Interfaces;

namespace UnitOfWorkPaging.Service
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _dataContext;

        public UnitOfWork(DataContext dataContext)
        {
            _dataContext = dataContext;
            ProductRepository = new ProductRepository(dataContext);
            CategoryRepository = new CategoryRepository(dataContext);
        }

        public IProductRepository ProductRepository { get ; set ; }
        public ICategoryRepository CategoryRepository { get; set ; }

        public int Complete()
        {
            return _dataContext.SaveChanges();
        }

        public void Dispose()
        {
            _dataContext.Dispose();
        }
    }
}
