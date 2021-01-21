using Microsoft.AspNetCore.Mvc;
using Polifloris.Data.Interfaces;

namespace Polifloris.Components
{
    public class CategoryMenu : ViewComponent
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryMenu(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public IViewComponentResult Invoke()
        {
            var categories = _categoryRepository.GetCategories();
            return View(categories);
        }
    }
}
