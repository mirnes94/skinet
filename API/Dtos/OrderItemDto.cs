using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities.OrderAggregate;

namespace API.Dtos
{
    public class OrderItemDto
    {
        public int ProductId{get;set;}

        public string ProductName{get;set;}

        public decimal PictureUrl { get; set; }
        public decimal Price{get;set;}
        public int Quantity{get;set;}
    }
}
