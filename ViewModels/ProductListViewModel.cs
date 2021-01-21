using Polifloris.Models;
using System.Collections.Generic;

namespace Polifloris.ViewModels
{
    public class ProductListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public string CurrentCategory { get; set; }
    }
}
