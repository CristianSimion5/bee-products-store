using Microsoft.AspNetCore.Mvc;
using Polifloris.Data.Interfaces;
using Polifloris.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polifloris.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository _productRepository;

        public HomeController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                FeaturedProducts = _productRepository.GetProducts()
            };

            return View(homeViewModel);
        }
    }
}
