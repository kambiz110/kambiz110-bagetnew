using Application.Comments.Dto;
using Application.Dtos;
using Application.Interfaces.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Comments.Command
{
    public interface IEditStatusCommentService
    {
        ResultDto Exequte(long[] ids, int _status, string userPersonCode, string ip);
        ResultDto<string> EditComment(EditCommentMessageDto dto);
    }
    public class EditStatusCommentService : IEditStatusCommentService
    {
        private readonly IDataBaseContext _context;
        private readonly IIdentityDatabaseContext identityDatabase;

        public EditStatusCommentService(IDataBaseContext context, IIdentityDatabaseContext identityDatabase)
        {
            _context = context;
            this.identityDatabase = identityDatabase;
        }
        public ResultDto<string> EditComment(EditCommentMessageDto dto)
        {
            var comment = _context.Comments.FirstOrDefault(p => p.Id == dto.Id);
            if (comment == null)
                return new ResultDto<string>
                {
                    Data = null,
                    IsSuccess = false,
                    Message = "خطا در ارسال اطلاعات!!!"
                };

           // comment.Name = dto.Name;
            comment.Message = dto.Message;

            var result = _context.SaveChanges();
            if (result > 0)
            {
                return new ResultDto<string>
                {
                    Data = dto.Message,
                    IsSuccess = true,
                    Message = "اطلاعات با موفقیت ویرایش شد."
                };
            }

            return new ResultDto<string>
            {
                Data = null,
                IsSuccess = false,
                Message = "ویرایش اطلاعات با خطا مواجه شد!!!"
            };
        }
        public ResultDto Exequte(long[] ids, int _status, string userPersonCode , string ip)
        {
            var user = identityDatabase.Users.FirstOrDefault(p => p.UserName == userPersonCode);
            var commentes = _context.Comments.Where(p => ids.Contains(p.Id) && p.Status != _status).ToList();
            if (commentes.Count > 0)
            {
                for (int i = 0; i < commentes.Count(); i++)
                {
                    commentes.ElementAt(i).Status = (byte)_status;
                    commentes.ElementAt(i).ConfirmedUserId = user.Id;
                }
                _context.SaveChanges();
                string postAction = "";
                switch (_status)
                {
                    case 1:
                        postAction = "منتشر شده"; break;
                    case 3:
                        postAction = "سطل زباله"; break;
                    default:
                        postAction = "منتشر نشده"; break;
                }
                return new ResultDto
                {
                    IsSuccess = true,
                    Message = $"وضعیت {commentes.Count()} دیدگاه به {postAction} با موفقیت تغییر کرد."
                };

            }
            return new ResultDto
            {
                IsSuccess = false,
                Message = "عملیات با شکست مواجه شد!!!"
            };
        }
    }
}
