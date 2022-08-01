using Application.Catalogs.CatalogTypes.Dto;
using Application.Dtos;
using Application.Interfaces.Contexts;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Catalogs.CatalogTypes.Query
{
  /// <summary>
  /// نمایش دسته بندی های اصلی برای جستجوی بالای صفحه مادر
  /// </summary>
    public interface IGetCategoreTypeHeaderSearchKey
    {
        BaseDto<List<GetCategoreTypeHeaderSearchKeyDto>> ListCatalogTypeBySortIndex(int type, int count , int? parentId);
    }
    public class GetCategoreTypeHeaderSearchKey : IGetCategoreTypeHeaderSearchKey
    {
        private readonly IDataBaseContext context;
        private readonly IMapper mapper;


        public GetCategoreTypeHeaderSearchKey(IDataBaseContext context, IMapper mapper
           )
        {
            this.context = context;
            this.mapper = mapper;
       
        }
        public BaseDto<List<GetCategoreTypeHeaderSearchKeyDto>> ListCatalogTypeBySortIndex(int type, int count, int? parentId)
        {
            var model = context.CatalogTypes
        .Where(p => p.SortIndex >= type && p.ParentCatalogTypeId == parentId).AsNoTracking()
        .OrderByDescending(p => p.SortIndex).Take(count)
         .AsQueryable();
            var result = mapper.ProjectTo<GetCategoreTypeHeaderSearchKeyDto>(model).ToList();
      
            return new BaseDto<List<GetCategoreTypeHeaderSearchKeyDto>>(true, new List<string> { "موفق" }, result);
        }
    }
}
