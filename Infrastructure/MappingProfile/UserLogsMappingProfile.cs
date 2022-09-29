using Application.Logs.Dto;
using AutoMapper;
using Domain.Logs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.MappingProfile
{
  public  class UserLogsMappingProfile : Profile
    {
        public UserLogsMappingProfile()
        {
            CreateMap<AddUserLogDto, UserLog>().ReverseMap();
            CreateMap<GetUserLogDto, UserLog>().ReverseMap();
        }
    }
}
