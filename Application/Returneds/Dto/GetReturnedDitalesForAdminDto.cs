using Application.Orders.Dto;
using Application.PostalProducts.Dto;
using Domain.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Returneds.Dto
{
  public  class GetReturnedDitalesForAdminDto
    {
        public int ReturnedId { get; set; }
        public int Amount { get; set; }
        public int OrderId { get; set; }
        public string userePhoneNumber { get; set; }
        public AddReturnedPostalProductDto postalProductDto { get; set; }
        public Address Address { get; set; }
        public DateTime Date { get; set; }
        public DateTime? PostDate { get; set; }
        public DateTime? RecivePostDate { get; set; }
        public ReturnedStatus ReturnedStatus { get; set; }
        public List<OrederItemsForOrderDto> OrederItems { get; set; }
    }
}
