using System.Collections.Generic;
using Polifloris.Models;

namespace Polifloris.Data.Interfaces
{
    public interface IProductRepository
    {
        Product GetProductById(int productId);
        IEnumerable<Product> GetProducts();
    }
}