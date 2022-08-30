using Application.Dtos;
using Application.Interfaces.Contexts;
using Application.Users.Dto;
using AutoMapper;
using Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Users.Query
{
   public interface IGetUsers
    {
        PaginatedItemsDto<UserShowAdminDto> AllUser(int pageIndex = 1, int pageSize = 20, string search = "");
    }

    public class GetUsers : IGetUsers
    {
        private readonly IIdentityDatabaseContext _identityDatabase;

        private readonly IMapper _mapper;

        public GetUsers(IIdentityDatabaseContext context, IMapper mapper)
        {
            _identityDatabase = context;
            _mapper = mapper;
        }
        public PaginatedItemsDto<UserShowAdminDto> AllUser(int pageIndex = 1, int pageSize = 20, string search = "")
        {
            int rowCount = 0;
            var query = _identityDatabase.Users.AsNoTracking().AsQueryable();
            if (!String.IsNullOrEmpty(search))
            {
                query = query.Where(p => p.FullName.Contains(search.Trim())|| p.UserName.Contains(search.Trim()) || p.PhoneNumber.Contains(search.Trim()));
            }
            if (query != null && query.Any())
            {
                var result = query.PagedResult(pageIndex, pageSize, out rowCount);
                var data = _mapper.ProjectTo<UserShowAdminDto>(result).ToList();
                return new PaginatedItemsDto<UserShowAdminDto>(pageIndex, pageSize, rowCount, data);
            }
                

            return new PaginatedItemsDto<UserShowAdminDto>(pageIndex, pageSize, rowCount, new List<UserShowAdminDto>());
        }
    }
}
