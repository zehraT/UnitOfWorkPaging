using Microsoft.AspNetCore.Mvc;

using UnitOfWorkPaging.Interfaces;

namespace UnitOfWorkPaging.ViewComponents
{
    public class MenuViewComponent:ViewComponent
    {
        private readonly IUnitOfWork _unitOfWork;
        public MenuViewComponent(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;  
        }
        public IViewComponentResult Invoke()
        {
            var categories = _unitOfWork.CategoryRepository.List();
            return View(categories);
        }
    }
}
