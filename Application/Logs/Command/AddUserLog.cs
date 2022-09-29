using Application.Interfaces.Contexts;
using Application.Logs.Dto;
using AutoMapper;
using Domain.Logs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Logs.Command
{
   public interface IAddUserLog
    {
        void adduserlog(AddUserLogDto dto);
    }
    public class AddUserLog : IAddUserLog
    {
        private readonly IDataBaseContext _dbContext;
        private readonly IMapper _mapper;
        public AddUserLog(IDataBaseContext DbContext, IMapper mapper)
        {
            _dbContext = DbContext;
            _mapper = mapper;
        }
        public void adduserlog(AddUserLogDto dto)
        {
            var ulog = _mapper.Map<UserLog>(dto);
            _dbContext.UserLogs.Add(ulog);
            _dbContext.SaveChanges();
 
        }
    }
}
