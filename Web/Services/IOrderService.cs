using System.Collections.Generic;
using Web.Models;

namespace Web.Services
{
    public interface IOrderService
    {
        IEnumerable<Order> GetOrders();
    }
}