using Application.Dtos;
using Application.Interfaces.Contexts;
using Application.Tickets.Dto;
using AutoMapper;
using Common;
using Domain.Tickets;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Tickets.Query
{
    public interface ICustomerGetTickets
    {
        PaginatedItemsDto<GetTicketsInCustomersDto> GetTickets(string userId , int pageIndex, int pageSize);
    }
    public class CustomerGetTickets : ICustomerGetTickets
    {
        private readonly IDataBaseContext context;
        private readonly IMapper mapper;

        public CustomerGetTickets(IDataBaseContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public PaginatedItemsDto<GetTicketsInCustomersDto> GetTickets(string userId, int pageIndex, int pageSize)
        {
            int rowCount = 0;
            var query = context.Tickets.Where(p => p.UserId == userId).AsNoTracking()
                  .OrderByDescending(p => p.Id)
                .AsQueryable();
            if (query != null && query.Any())
            {
                var result = query.PagedResult(pageIndex, pageSize, out rowCount)
                       .ToList();
                if (result.Count > 0)
                {
                    var ticket = mapper.Map<List<GetTicketsInCustomersDto>>(result);
                    return new PaginatedItemsDto<GetTicketsInCustomersDto>(pageIndex, pageSize, rowCount, ticket);

                }
            }

                    return new PaginatedItemsDto<GetTicketsInCustomersDto>(pageIndex, pageSize, rowCount, new List<GetTicketsInCustomersDto>());
        }
    }

}
