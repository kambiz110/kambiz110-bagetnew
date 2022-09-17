using Application.Tickets.Dto;
using AutoMapper;
using Domain.Tickets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.MappingProfile
{
   public class TicketMappingProfile : Profile
    {
        public TicketMappingProfile()
        {
            // پروفایل مپ افزودن مورد جدید
          CreateMap<AddTicketDto, Ticket>().ReverseMap();
          CreateMap<GetTicketsInCustomersDto, Ticket>().ReverseMap();
          CreateMap<AddAnswerDto, Ticket>().ReverseMap();
          CreateMap<GetAdminTicketDto, Ticket>().ReverseMap()
                .ForMember(dest => dest.status, opt =>
                opt.MapFrom(src => String.IsNullOrEmpty(src.Answer)?false:true));
        }
    }
}
