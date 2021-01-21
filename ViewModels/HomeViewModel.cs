using Polifloris.Models;
using System.Collections.Generic;

namespace Polifloris.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Product> FeaturedProducts { get; set; }
    }
}
