using Application.PostalProducts.Dto;
using Domain.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Orders.Dto
{
   public class OderDitalesForCustomerDto
    {
        public Guid PaymentId { get; set; }
        public int Amount { get; set; }
        public int OrderId { get; set; }
        public bool IsEnableReturned { get; set; }
        public AddPostalProductDto postalProductDto { get; set; }
        public Address Address { get; set; }
        public DateTime Date { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public List<OrederItemsForOrderDto> OrederItems { get; set; }
    }
}
