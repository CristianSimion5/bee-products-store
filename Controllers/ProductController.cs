using Microsoft.AspNetCore.Mvc;
using Polifloris.Data.Interfaces;
using Polifloris.Models;
using Polifloris.ViewModels;
using System.Collections.Generic;

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

        public IActionResult List(string category)
        {
            string _category = category;
            IEnumerable<Product> products;

            string currentCategory = string.Empty;

            if (string.IsNullOrEmpty(category))
            {
                products = _productRepository.GetProducts();
                currentCategory = "Toate produsele";
                ViewBag.Name = "Toate produsele sunt afisate aici";
            }
            else
            {
                products = _productRepository.Find(p => p.Category.CategoryName
                    .Equals(_category));
                
                currentCategory = _category;
                ViewBag.Name = string.Format(
                    "Produsele din categoria {0:string} sunt afisate aici", 
                    currentCategory);
            }

            
            ProductListViewModel productListViewModel = new ProductListViewModel
            {
                Products = products,
                CurrentCategory = currentCategory
            };

            return View(productListViewModel);
        }
    }
}