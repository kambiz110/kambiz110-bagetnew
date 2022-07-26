using Application.Catalogs.CatalogTypes.Dto;
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
    /// نمایش آبشاری منو ها در صفحه هدر صفحه
    /// </summary>
   public interface IRenderCategoriesMenuService
    {
        List<CatalogTypeCategoriMenu> Exequt();
    }
   public class RenderCategoriesMenuService : IRenderCategoriesMenuService
    {
        private readonly IDataBaseContext context;
        private readonly IMapper mapper;

        public RenderCategoriesMenuService(IDataBaseContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public List<CatalogTypeCategoriMenu> Exequt()
        {
            var model = context.CatalogTypes.AsNoTracking().AsQueryable();
               
                
            var result = mapper.ProjectTo<CatalogTypeCategoriMenu>(model).ToList();
            return result;
        }
    }
}
