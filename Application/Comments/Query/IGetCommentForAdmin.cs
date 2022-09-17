using Application.Comments.Dto;
using Application.Dtos;
using Application.Interfaces.Contexts;
using AutoMapper;
using Common;
using Domain.Comments;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Comments.Query
{
    public interface IGetCommentForAdmin
    {
        ResultDto<GetCommentForAdminDto> Exequte(int PageSize, int PageNo, string userName);
        ResultDto<GetCommentForAdminDto> Exequte(int PageSize, int PageNo, string searchKey, string userName);
    }
    public class GetCommentForAdmin : IGetCommentForAdmin
    {
        private readonly IDataBaseContext _context;
        private readonly IMapper _mapper;
        private readonly IIdentityDatabaseContext identityDatabase;

        public GetCommentForAdmin(IDataBaseContext context, IMapper mapper , IIdentityDatabaseContext identityDatabase)
        {
            _context = context;
            _mapper = mapper;
            this.identityDatabase = identityDatabase;
        }

        public ResultDto<GetCommentForAdminDto> Exequte(int PageSize, int PageNo, string userName)
        {
            int rowCount = 0;
            var result = getCommentsWithClaim(userName, "");
            if (result != null)
            {
                var pagingresult = result.ToPaged(PageNo, PageSize, out rowCount).ToList();
                var modelMaped = _mapper.Map<List<CommentViewModelDto>>(pagingresult);
                var model = new GetCommentForAdminDto
                {
                    PagerDto = new PagerDto
                    {
                        PageNo = PageNo,
                        PageSize = PageSize,
                        TotalRecords = rowCount
                    },
                    comments = modelMaped
                };

                return new ResultDto<GetCommentForAdminDto>
                {
                    Data = model,
                    IsSuccess = true,
                    Message = "موفق"
                };
            }
            return new ResultDto<GetCommentForAdminDto>
            {
                Data = null,
                IsSuccess = false,
                Message = "مقداری یافت نگردید"
            };
        }

        public ResultDto<GetCommentForAdminDto> Exequte(int PageSize, int PageNo, string searchKey, string userName)
        {
            int rowCount = 0;

            var result = getCommentsWithClaim(userName, searchKey);
            if (result != null)
            {
                var pagingresult = result.ToPaged(PageNo, PageSize, out rowCount).ToList();
                var modelMaped = _mapper.Map<List<CommentViewModelDto>>(pagingresult);
                var model = new GetCommentForAdminDto
                {
                    PagerDto = new PagerDto
                    {
                        PageNo = PageNo,
                        PageSize = PageSize,
                        TotalRecords = rowCount
                    },
                    comments = modelMaped
                };

                return new ResultDto<GetCommentForAdminDto>
                {
                    Data = model,
                    IsSuccess = true,
                    Message = "موفق"
                };
            }
            return new ResultDto<GetCommentForAdminDto>
            {
                Data = null,
                IsSuccess = false,
                Message = "مقداری یافت نگردید"
            };
        }

        private IQueryable<Comment> getCommentsWithClaim(string userName, string searchKey)
        {
            var user = identityDatabase.Users
            .Where(p => p.UserName == userName)
            .AsNoTracking().FirstOrDefault();


            var result = _context.Comments.Where(p => p.Status == 0)
            .AsNoTracking()
            .Include(p => p.Post)
            .Include(p => p.Parent)
            .AsQueryable();

            if (searchKey.Trim() != "")
            {
                result = result.Where(p => p.Message.Contains(searchKey));
            }
            if (result!=null && result.Any())
            {
                return result;
            }

            else
            {
                return null;
            }

        }



    }
}
