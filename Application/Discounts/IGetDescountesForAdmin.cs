using Application.Discounts.AddNewDiscountServices;
using Application.Dtos;
using Application.Interfaces.Contexts;
using AutoMapper;
using Common;
using Domain.Discounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Discounts
{
   public interface IGetDescountesForAdmin
    {
        public PaginatedItemsDto<AddNewDiscountDto> GetListDescounts(int page , int pageSize);
    }
    public class GetDescountesForAdmin : IGetDescountesForAdmin
    {
        private readonly IDataBaseContext context;
        private readonly IMapper mapper;

        public GetDescountesForAdmin(IDataBaseContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public PaginatedItemsDto<AddNewDiscountDto> GetListDescounts(int page, int pageSize)
        {
            int rowCount = 0;
            var query = context.Discount
           
                .OrderByDescending(p => p.Id)
                .AsQueryable();
            var data = query.PagedResult(page, pageSize, out rowCount)
                    .AsQueryable();
            var model = mapper.ProjectTo<AddNewDiscountDto>(data).ToList();
            return new PaginatedItemsDto<AddNewDiscountDto>(page, pageSize, rowCount, model);
        }
    }
}
