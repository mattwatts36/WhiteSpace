using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json;
using Web.Models;

namespace Web.Services
{
    public class OrderService : IOrderService
    {
        const string OrdersApiUri = "https://localhost:44347/api/order";
        
        public IEnumerable<Order> GetOrders()
        {
            var webClient = new WebClient();
            var orderList = JsonConvert.DeserializeObject<IEnumerable<Order>>(webClient.DownloadString(OrdersApiUri));
            
            return orderList;
        }


    }
}