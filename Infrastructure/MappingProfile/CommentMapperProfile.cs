using Application.Comments.Dto;
using AutoMapper;
using Domain.Comments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.MappingProfile
{
   public class CommentMapperProfile : Profile
    {
        public CommentMapperProfile()
        {
            //  CreateMap<CatalogType, GetCategoreTypeHeaderSearchKeyDto>().ReverseMap();
            CreateMap<Comment, CommentViewModelDto>()
                   .ForMember(ds => ds.ParentTitle,
                   src => src.MapFrom(src => (src.Parent != null) ? src.Parent.Message : ""));
            CreateMap<AddCommentDto, Comment>();
        }
      
    }
}
