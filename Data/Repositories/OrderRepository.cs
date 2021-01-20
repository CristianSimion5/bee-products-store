using Polifloris.Data.Interfaces;
using Polifloris.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polifloris.Data.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _context;
        private readonly ShoppingCart _shoppingCart;

        public OrderRepository(AppDbContext context, ShoppingCart shoppingCart)
        {
            _context = context;
            _shoppingCart = shoppingCart;
        }

        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;
            _context.Orders.Add(order);
            _context.SaveChanges();

            var shoppingCartItems = _shoppingCart.ShoppingCartItems;

            foreach (var item in shoppingCartItems)
            {
                var orderDetail = new OrderDetail()
                {
                    Amount = item.Amount,
                    ProductId = item.Product.ProductId,
                    OrderId = order.OrderId,
                    Price = item.Product.Price
                };
                _context.OrderDetails.Add(orderDetail);
            }

            _context.SaveChanges();
        }
    }
}
