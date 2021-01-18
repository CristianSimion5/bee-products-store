using System.Collections.Generic;
using Polifloris.Models;

namespace Polifloris.Data.Interfaces
{
    public interface ICategoryRepository
    {
         IEnumerable<Category> GetCategories();
    }
}