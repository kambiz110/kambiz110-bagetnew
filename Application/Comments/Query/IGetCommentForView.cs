using Application.Comments.Dto;
using Application.Dtos;
using Application.Interfaces.Contexts;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Comments.Query
{
    public interface IGetCommentForView
    {
        ResultDto<List<CommentViewModelDto>> Exequte(int postId);
    }
    public class GetCommentForView : IGetCommentForView
    {
        private readonly IDataBaseContext _context;
        private readonly IMapper _mapper;

        public GetCommentForView(IDataBaseContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public ResultDto<List<CommentViewModelDto>> Exequte(int postId)
        {
            var commentes = _context.Comments.AsNoTracking()
                 .Where(p => p.PostId == postId && p.Status == 1)
                 .Include(p => p.Parent)
                 .ToList();
            if (commentes != null && commentes.Count() > 0)
            {
                var model = _mapper.Map<List<CommentViewModelDto>>(commentes);
                return new ResultDto<List<CommentViewModelDto>>
                {
                    Data = model,
                    IsSuccess = true,
                    Message = "موفق"
                };
            }
            return new ResultDto<List<CommentViewModelDto>>
            {
                Data = null,
                IsSuccess = false,
                Message = "هیچ دیدگاهی  یافت نگردید!!!"
            };
        }
    }
}
