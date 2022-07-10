using Application.Discounts.AddNewDiscountServices;
using Application.Discounts.Dto;
using Application.Interfaces.Contexts;
using AutoMapper;
using Domain.Discounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Discounts.EditDiscountServices
{
    public interface IEDitDiscount
    {
        bool Execute(GetDescountsForEditViewModel discount);
    }
    public class EDitDiscount : IEDitDiscount
    {
        private readonly IDataBaseContext context;
        private readonly IMapper mapper;

        public EDitDiscount(IDataBaseContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public bool Execute(GetDescountsForEditViewModel dto)
        {
            var discount = context.Discount.Where(p => p.Id == dto.Id).FirstOrDefault();
            mapper.Map( dto, discount);
      

            if (dto.appliedToCatalogItem != null)
            {
                var catalogItems = context.CatalogItems.Where(p => dto.appliedToCatalogItem.Contains(p.Id)).ToList();
                discount.CatalogItems = catalogItems;
            }

            context.Discount.Update(discount);
         var result =   context.SaveChanges();
            return result >0 ? true : false;
        }
    }
}
