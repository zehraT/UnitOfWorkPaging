using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnitOfWorkPaging.Interfaces;
using UnitOfWorkPaging.Models;

namespace UnitOfWorkPaging.Service
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly DataContext _dataContext;
        public ProductRepository(DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }

        public IEnumerable<Product> GetByCategoryId(int id)
        {
            return _dataContext.Products.Where(x => x.CategoryID == id);
        }
    }
}
