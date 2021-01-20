using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Polifloris.Models;

namespace Polifloris.Data.Interfaces
{
    public interface IProductRepository
    {
        Product GetProductById(int productId);
        IEnumerable<Product> GetProducts();
        IEnumerable<Product> Find(Expression<Func<Product, bool>> expression);
    }
}