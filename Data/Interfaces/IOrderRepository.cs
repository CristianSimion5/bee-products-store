using Polifloris.Models;

namespace Polifloris.Data.Interfaces
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}
