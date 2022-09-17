using Application.Interfaces.Contexts;
using Application.Tickets.Dto;
using AutoMapper;
using Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Tickets.Query
{
    public interface IAdminGetTickets
    {
        GetTicketAdminWithPager GetTickets(int PageSize, int PageNo, string searchKey, bool answered);
    }
    public class AdminGetTickets : IAdminGetTickets
    {
        private readonly IDataBaseContext context;
        private readonly IMapper mapper;
        private readonly IIdentityDatabaseContext identityContext;
        public AdminGetTickets(IDataBaseContext context, IMapper mapper, IIdentityDatabaseContext identityContext)
        {
            this.context = context;
            this.mapper = mapper;
            this.identityContext = identityContext;
        }

        public GetTicketAdminWithPager GetTickets(int PageSize, int PageNo, string searchKey, bool answered)
        {
            int rowCount = 0;
            var model = context.Tickets.AsNoTracking()
                  .OrderByDescending(p => p.Id)
                .AsQueryable();
            if (!String.IsNullOrEmpty(searchKey))
            {
                model = model.Where(p => p.Title.Contains(searchKey.Trim()) || p.PhoneNumber.Contains(searchKey.Trim())).AsQueryable();
            }
            if (answered)
            {
                model = model.Where(p => p.Answer !=null).AsQueryable();
            }
            if (!answered)
            {
                model = model.Where(p => p.Answer == null).AsQueryable();
            }
            if (model != null && model.Any())
            {
                var result = model.PagedResult(PageNo, PageSize, out rowCount)
                       .ToList();
                if (result.Count > 0)
                {
                    var ticket = mapper.Map<List<GetAdminTicketDto>>(result);
                    for (int i = 0; i < ticket.Count(); i++)
                    {
                        ticket.ElementAt(i).FullName = identityContext.Users.Where(p => p.Id == ticket.ElementAt(i).UserId).AsNoTracking().FirstOrDefault().FullName;
                    }
                    return new GetTicketAdminWithPager
                    {
                        Tickets = ticket,
                        PagerDto = new Dtos.PagerDto
                        {
                            PageNo = PageNo,
                            PageSize = PageSize,
                            TotalRecords = rowCount
                        }
                    };

                }
            }
            return null;
        }
    }
}
