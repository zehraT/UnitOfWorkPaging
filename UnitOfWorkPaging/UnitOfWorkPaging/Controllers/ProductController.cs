using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using UnitOfWorkPaging.Interfaces;
using UnitOfWorkPaging.Models;

namespace UnitOfWorkPaging.Controllers
{
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public ProductController(IUnitOfWork unitOfWork)
        {
            _unitOfWork=unitOfWork;
        }

        public IActionResult GetByCategoryId(int id,int page=1,int pageSize=3)
        {
            var productList = _unitOfWork.ProductRepository.GetByCategoryId(id);
            X.PagedList.PagedList<Product> model = new X.PagedList.PagedList<Product>(productList.Where(a => a.CategoryID == id), page, pageSize);
            return View(model);

        }


        public IActionResult Index()
        {
            return View();
        }
    }
}