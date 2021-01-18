using System.Collections.Generic;
using Polifloris.Data.Interfaces;
using Polifloris.Models;

namespace Polifloris.Data.Mocks
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> GetCategories()
        {
            return new List<Category>
            {
                new Category { CategoryName = "Miere", Description = "Renumitul aliment cu numeroase beneficii" },
                new Category { CategoryName = "Ceara", Description = "Ingredientul folosit în numeroase locuri" }
            };
        }
    }
}