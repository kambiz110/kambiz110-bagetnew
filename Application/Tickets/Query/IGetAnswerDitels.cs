using Application.Interfaces.Contexts;
using Application.Tickets.Dto;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Tickets.Query
{
  public  interface IGetAnswerDitels
    {
        AddAnswerDto AnswerDitels(long id);
    }
  public  class GetAnswerDitels : IGetAnswerDitels
    {
        private readonly IDataBaseContext context;
        private readonly IMapper mapper;
        private readonly IIdentityDatabaseContext identityContext;

        public GetAnswerDitels(IDataBaseContext context, IMapper mapper, IIdentityDatabaseContext identityContext)
        {
            this.context = context;
            this.mapper = mapper;
            this.identityContext = identityContext;
        }

        AddAnswerDto IGetAnswerDitels.AnswerDitels(long id)
        {
            var ticket = context.Tickets.FirstOrDefault(p=>p.Id==id);
            if (ticket!=null)
            {
                var model = mapper.Map<AddAnswerDto>(ticket);
                model.FullName = identityContext.Users.Where(p => p.Id == ticket.UserId).AsNoTracking().FirstOrDefault().FullName;
                return model;
            }
            return null;
        }

    }
}
