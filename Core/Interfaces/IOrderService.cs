using System.Collections.Generic;
using System.Threading.Tasks;

using Core.Entities.OrderAggregate;
namespace Core.Interfaces
{
    public interface IOrderService
    {
       public Task<Order> CreateOrderAsync(string buyerEmail, int deliveryMethod,
        string basketId,Address shippingAddress);
       public Task<IReadOnlyList<Order>> GetOrdersForUserAsync(string buyerEmail);
      public Task<Order> GetOrderByIdAsync(int id, string buyerEmail);

       Task<IReadOnlyList<DeliveryMethod>> GetDeliveryMethodAsync();
    }
}