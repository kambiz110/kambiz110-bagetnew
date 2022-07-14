using Application.Dtos;
using Application.Interfaces.Contexts;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Catalogs.CatalogTypes
{
   public interface IMenuCatolgType
    {
        BaseDto<List<CatalogTypeDto>> ListCatalogTypeBySortIndex(int type);
    }
    public class MenuCatolgType : IMenuCatolgType
    {
        private readonly IDataBaseContext context;
        private readonly IMapper mapper;

        public MenuCatolgType(IDataBaseContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        public BaseDto<List<CatalogTypeDto>> ListCatalogTypeBySortIndex(int type)
        {
            var model = context.CatalogTypes
        .Where(p => p.SortIndex == type)
         .Include(p => p.CatalogTypeImage)
         .AsQueryable();
            var result = mapper.ProjectTo<CatalogTypeDto>(model).ToList();
            return new BaseDto<List<CatalogTypeDto>>(true,new List<string> { "موفق"},result);
        }
    }

}
