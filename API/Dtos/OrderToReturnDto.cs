using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities.Identity;
using Core.Entities.OrderAggregate;

namespace API.Dtos
{
    public class OrderToReturnDto
    {
        public int Id {get;set;}
        public string BuyerEmail { get; set; }
    public DateTimeOffset OrderDate  { get; set; } = 
DateTimeOffset.Now;
public Core.Entities.OrderAggregate.Address ShipToAddress {get;set;}
public DeliveryMethod DeliveryMethod{get;set;}
public decimal ShippingPrice { get; set; }
public IReadOnlyList<OrderItemDto>  OrderItems{get;set;}
public decimal Subtotal{get;set;}

public decimal Total{get;set;}
public OrderStatus Status { get; set; }
public string PaymentIntentId { get; set; }
    }
}
