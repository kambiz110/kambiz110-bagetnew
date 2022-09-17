using Application.Interfaces.Contexts;
using Application.Tickets.Dto;
using AutoMapper;
using Domain.Tickets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Tickets.Command
{
    public interface IAddTicketService
    {
        Task Add(AddTicketDto dto);
    }
    public class AddTicketService : IAddTicketService
    {
        private readonly IDataBaseContext context;
        private readonly IMapper mapper;

        public AddTicketService(IDataBaseContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task Add(AddTicketDto dto)
        {
            var ticket = mapper.Map<Ticket>(dto);
            context.Tickets.Add(ticket);
            await context.SaveChangesAsync();

        }
    }
}
