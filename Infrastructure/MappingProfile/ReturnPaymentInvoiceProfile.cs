using Application.ReturnPaymentInvoice.Dto;
using AutoMapper;
using Domain.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.MappingProfile
{
   public class ReturnPaymentInvoiceProfile :Profile
    {
        public ReturnPaymentInvoiceProfile()
        {
            CreateMap<ReturnPaymentInvoice, AddReturnPaymentInvoiceDto>().ReverseMap();
        }
    }
}
