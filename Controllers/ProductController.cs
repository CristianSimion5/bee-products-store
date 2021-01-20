using Microsoft.AspNetCore.Mvc;
using Polifloris.Data.Interfaces;
using Polifloris.ViewModels;

namespace Polifloris.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;

        public ProductController(ICategoryRepository categoryRepository, IProductRepository productRepository)
        {
            _categoryRepository = categoryRepository;
            _productRepository = productRepository;
        }

        public IActionResult List()
        {
            ViewBag.Name = "Toate produsele sunt afisate aici";
            ProductListViewModel vm = new ProductListViewModel
            {
                Products = _productRepository.GetProducts(),
                CurrentCategory = "Miere"
            };

            return View(vm);
        }
    }
}