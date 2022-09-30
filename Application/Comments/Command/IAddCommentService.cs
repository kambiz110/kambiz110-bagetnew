using Application.Comments.Dto;
using Application.Dtos;
using Application.Interfaces.Contexts;
using AutoMapper;
using Common.Useful;
using Domain.Comments;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Comments.Command
{
   public interface IAddCommentService
    {
        ResultDto<string> Exequte(AddCommentDto dto, string userName);

    }
   public class AddCommentService : IAddCommentService
    {
        private readonly IDataBaseContext _context;
        private readonly IMapper _mapper;
        private readonly IIdentityDatabaseContext identityDatabase;

        public AddCommentService(IDataBaseContext context, IMapper mapper, IIdentityDatabaseContext identityDatabase)
        {
            _context = context;
            _mapper = mapper;
            this.identityDatabase = identityDatabase;
        }
      
        public ResultDto<string> Exequte(AddCommentDto dto, string userName)
        {

            if (!String.IsNullOrEmpty(userName) && userName.Trim() != "")
            {
                var user = identityDatabase.Users.Where(p => p.UserName == userName)
                    .AsNoTracking().FirstOrDefault();
                dto.UserId = user.Id;
              
            }

            var dt1 = DateTime.Now.ToDateConvertDateTime();
            if (!_context.Comments.Where(p => p.IP == dto.IP && p.CommentDate.Date == dt1.Date).Any())
            {
                var comment = _mapper.Map<Comment>(dto);
                comment.CommentDate = DateTime.Now;
                _context.Comments.Add(comment);
                var result = _context.SaveChanges();
                if (result > 0)
                {
                    return new ResultDto<string>
                    {
                        Data = dto.Message,
                        IsSuccess = true,
                        Message = "موفق"
                    };
                }

                return new ResultDto<string>
                {
                    Data = null,
                    IsSuccess = false,
                    Message = "ناموفق"
                };
            }

            return new ResultDto<string>
            {
                Data = null,
                IsSuccess = false,
                Message = "شما در روز فقط یک نظر در سایت می توانید درج نمائید"
            };
   
        }
    }
}
