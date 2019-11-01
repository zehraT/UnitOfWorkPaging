
using UnitOfWorkPaging.Interfaces;
using UnitOfWorkPaging.Models;

namespace UnitOfWorkPaging.Service
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly DataContext _dataContext;
        public CategoryRepository(DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }
    }
}
