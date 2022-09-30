using Application.Dtos;
using Application.Interfaces.Contexts;
using Application.Logs.Dto;
using Application.Logs.Query;
using AutoMapper;
using Common;
using Common.Useful;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Logs.Query
{
   public interface IGetUserlogs
    {
        public ResultDto<GetUserlogsWithPeger> GetUserLogs(int PageSize, int PageNo, string username);
    }
}
   public class GetUserlogs : IGetUserlogs
{
    private readonly IDataBaseContext _dbContext;
    private readonly IMapper _mapper;
    public GetUserlogs(IDataBaseContext DbContext, IMapper mapper)
    {
        _dbContext = DbContext;
        _mapper = mapper;
    }

    public ResultDto<GetUserlogsWithPeger> GetUserLogs(int PageSize, int PageNo, string username)
    {
        int rowCount = 0;
        var model = _dbContext.UserLogs
       .AsNoTracking()
       .OrderByDescending(p => p.InsertTime)
       .AsQueryable();
        if (!String.IsNullOrEmpty(username))
        {
            model = model.Where(p => p.userName.Contains(username.Trim())).AsQueryable();
        }
        var date = new GetUserlogsWithPeger() { };
        if (model != null)
        {
            var modelList = model.ToPaged(PageNo, PageSize, out rowCount).ToList();
            var result = _mapper.Map<List<GetUserLogDto>>(modelList);
            for (int i = 0; i < result.Count; i++)
            {
                result.ElementAt(i).EventName = StaticList.UserLogListKeyValuePair.FirstOrDefault(p => p.Value == (int)result.ElementAt(i).userEvent).Key;
            }
                date.UserLogs = result;
            date.PagerDto = new PagerDto
            {
                PageNo = PageNo,
                PageSize = PageSize,
                TotalRecords = rowCount
            };
            return new ResultDto<GetUserlogsWithPeger>
            {

                Data = date,
                IsSuccess = true,
                Message = "Success"
            };
        }
        return new ResultDto<GetUserlogsWithPeger>
        {
            Data = null,
            IsSuccess = false,
            Message = "Warninge"
        }; ;
    }
}

