using Application.Interfaces.Contexts;
using Application.ReturnPaymentInvoice.Dto;
using AutoMapper;
using Domain.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ReturnPaymentInvoice.Commend
{
   public interface IAddReturnPaymentInvoice
    {
        Task addDataToDb(AddReturnPaymentInvoiceDto dto);
    }
   public class AddReturnPaymentInvoice : IAddReturnPaymentInvoice
    {
        private readonly IDataBaseContext context;
        private readonly IMapper _mapper;
        public AddReturnPaymentInvoice(IDataBaseContext context, IMapper mapper)
        {
            this.context = context;
            _mapper = mapper;
        }

        public async Task addDataToDb(AddReturnPaymentInvoiceDto dto)
        {
            var paymentInvoice = _mapper.Map<Domain.Payments.ReturnPaymentInvoice>(dto);
            context.ReturnPaymentInvoices.Add(paymentInvoice);
            var returned = context.Returneds.FirstOrDefault(p => p.Id == dto.ReturnedId);
            returned.ReturnedStatus = Domain.Order.ReturnedStatus.ReturnPaymentInvoice;

            await context.SaveChangesAsync();
        }
    }
}
