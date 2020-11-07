using System.Linq;
using Web.Services;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class OrderController : Controller
    {
        public ViewResult Order()
        {
            var orderService = new OrderService();
            var orders = orderService.GetOrders();
            
            var orderId = orders.Select(x => x.Ref).FirstOrDefault();
            
            return View("Order", orders);
        }

        public ViewResult OrderDetails(string itemRef)
        {
            var orderService = new OrderService();
            var orderDetails = orderService.GetOrders().FirstOrDefault(x => x.Ref == itemRef)?.Items;
           
            return View("OrderDetails",orderDetails);
        }
    }
}