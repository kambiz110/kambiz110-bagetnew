using Application.Discounts.AddNewDiscountServices;
using Application.Discounts.Dto;
using Application.Dtos;
using Application.Interfaces.Contexts;
using AutoMapper;
using Common;
using Domain.Discounts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Discounts
{
   public interface IGetDescountesForAdmin
    {
        public PaginatedItemsDto<GetDescountsForAdminViewModel> GetListDescounts(int page , int pageSize);
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

        public PaginatedItemsDto<GetDescountsForAdminViewModel> GetListDescounts(int page, int pageSize)
        {
            int rowCount = 0;
            var query = context.Discount
                .Where(p=>p.Statse==true).AsNoTracking()
                .OrderByDescending(p => p.Id)
                .AsQueryable();
            if (query!=null)
            {
         var data = query.PagedResult(page, pageSize, out rowCount)
                    .AsQueryable();
            var model = mapper.ProjectTo<GetDescountsForAdminViewModel>(data).ToList();
                return new PaginatedItemsDto<GetDescountsForAdminViewModel>(page, pageSize, rowCount, model);
            }
   
            return new PaginatedItemsDto<GetDescountsForAdminViewModel>(page, pageSize, rowCount, null);
        }
    }
}
