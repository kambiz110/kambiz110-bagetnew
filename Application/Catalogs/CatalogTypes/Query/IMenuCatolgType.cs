using Application.Catalogs.CatalogItems.UriComposer;
using Application.Dtos;
using Application.Interfaces.Contexts;
using AutoMapper;
using Common.Useful;
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
        BaseDto<List<CatalogTypeDto>> ListCatalogTypeBySortIndex(int type , int count);
    }
    public class MenuCatolgType : IMenuCatolgType
    {
        private readonly IDataBaseContext context;
        private readonly IMapper mapper;


        public MenuCatolgType(IDataBaseContext context, IMapper mapper
            )
        {
            this.context = context;
            this.mapper = mapper;
     
        }
        public BaseDto<List<CatalogTypeDto>> ListCatalogTypeBySortIndex(int type, int count)
        {
            var model = context.CatalogTypes
        .Where(p => p.SortIndex >= type && p.ParentCatalogTypeId==null)
        .OrderByDescending(p=>p.SortIndex).Take(count)
         .Include(p => p.CatalogTypeImage)
         .AsQueryable();
            var result = mapper.ProjectTo<CatalogTypeDto>(model).ToList();
            for (int i = 0; i < result.Count; i++)
            {
                if (result.ElementAt(i).CatalogTypeImage!=null)
                {
     result.ElementAt(i).CatalogTypeImage.Src = GlobalConstants.serverImageUrl+(result.ElementAt(i).CatalogTypeImage.Src);
          
                }
             }
            return new BaseDto<List<CatalogTypeDto>>(true,new List<string> { "موفق"},result);
        }
    }

}
