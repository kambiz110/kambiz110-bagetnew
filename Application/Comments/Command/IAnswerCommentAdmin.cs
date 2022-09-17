using Application.Comments.Dto;
using Application.Dtos;
using Application.Interfaces.Contexts;
using AutoMapper;
using Domain.Comments;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Comments.Command
{
   public interface IAnswerCommentAdmin
    {
        ResultDto<string> Exequte(AjaxAnswerCommentDto dto, string userName, string ip);
    }
    public class AnswerCommentAdmin : IAnswerCommentAdmin
    {
        private readonly IDataBaseContext _context;
        private readonly IMapper _mapper;
        private readonly IIdentityDatabaseContext identityDatabase;

        public AnswerCommentAdmin(IDataBaseContext context, IMapper mapper, IIdentityDatabaseContext identityDatabase)
        {
            _context = context;
            _mapper = mapper;
            this.identityDatabase = identityDatabase;
        }

        public ResultDto<string> Exequte(AjaxAnswerCommentDto dto, string userName, string ip)
        {
           Comment addComment = new Comment();
            if (!String.IsNullOrEmpty(userName) && userName.Trim() != "")
            {
                var user = identityDatabase.Users.Where(p => p.UserName == userName)
                    .AsNoTracking().FirstOrDefault();
                addComment.UserId = user.Id;
                addComment.Name = user.FullName;
               
            }
         
            addComment.IP = ip;
            addComment.Message = dto.Answer;
            addComment.ParentId = dto.Commentid;
            addComment.PostId = dto.Postid;
            addComment.CommentDate = DateTime.Now;
            _context.Comments.Add(addComment);
            var result = _context.SaveChanges();
            if (result > 0)
            {
                return new ResultDto<string>
                {
                    Data = dto.Answer,
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
    }
}
