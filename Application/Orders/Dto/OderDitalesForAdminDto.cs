using Application.PostalProducts.Dto;
using Domain.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Orders.Dto
{
  public  class OderDitalesForAdminDto
    {
        public Guid PaymentId { get; set; }
        public int Amount { get; set; }
        public int OrderId { get; set; }
        public AddPostalProductDto postalProductDto { get;  set; }
        public Address Address { get;  set; }
        public DateTime Date { get; set; }

        public OrderStatus OrderStatus { get; set; }
        public List<OrederItemsForOrderDto> OrederItems { get; set; }
    }
    public class OrederItemsForOrderDto
    {

            public int Id { get; set; }
            public int CatalogItemid { get; set; }
            public string ProductName { get; set; }
            public int UnitPrice { get; set; }
            public int Units { get; set; }

    }
}
