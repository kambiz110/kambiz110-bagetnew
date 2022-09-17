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
   public interface IAddAnswerInTicket
    {
        Task addAnswer(AddAnswerDto dto);
    }
   public class AddAnswerInTicket : IAddAnswerInTicket
    {
        private readonly IDataBaseContext context;
        private readonly IMapper mapper;

        public AddAnswerInTicket(IDataBaseContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task addAnswer(AddAnswerDto dto)
        {
            var ticket = context.Tickets.FirstOrDefault(p=>p.Id==dto.Id);

            mapper.Map(dto, ticket);
            ticket.AtAnswerDate = DateTime.Now;
            context.Tickets.Update(ticket);
            await context.SaveChangesAsync();
        }
    }
}
