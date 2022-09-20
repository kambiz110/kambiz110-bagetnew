using Application.Catalogs.CatalogCars.Dto;
using Application.Catalogs.CatalogCompany.Dto;
using Application.Catalogs.CatalogItems.UriComposer;
using Application.Dtos;
using Application.Interfaces.Contexts;
using AutoMapper;
using Common;
using Common.Useful;
using Domain.Catalogs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Catalogs.CatalohItems.CatalogItemServices
{
    public class CatalogItemService : ICatalogItemService
    {

        private readonly IDataBaseContext context;
        private readonly IMapper mapper;
       

        public CatalogItemService(IDataBaseContext context
            , IMapper mapper
            )
        {
            this.context = context;
            this.mapper = mapper;
            
        }

        public void AddToMyFavourite(string UserId, int CatalogItemId)
        {
            var catalogItem = context.CatalogItems.Find(CatalogItemId);
            CatalogItemFavourite catalogItemFavourite = new CatalogItemFavourite
            {
                CatalogItem = catalogItem,
                UserId = UserId,
            };
            context.CatalogItemFavourites.Add(catalogItemFavourite);
            context.SaveChanges();
        }

        public List<CatalogBrandDto> GetBrand()
        {
            var brands = context.CatalogBrands
           .OrderBy(p => p.Brand).Take(500).ToList();

            var data = mapper.Map<List<CatalogBrandDto>>(brands);
            return data;
        }
        public List<CompanyDto> GetCompanes()
        {
            var companes = context.CatalogCompanes
           .OrderBy(p => p.Name).Take(500).ToList();

            var data = mapper.Map<List<CompanyDto>>(companes);
            return data;
        }
        public PaginatedItemsDto<CatalogItemListItemDto> GetCatalogList(int page, int pageSize, SearchInCategoreItemsDto dto)
        {
            int rowCount = 0;
            var data = context.CatalogItems
                .Include(p => p.CatalogType)
                .Include(p => p.CatalogBrand)
                .Include(p => p.CatalogCompany)
                .Include(p => p.CatologCar)
                .ToPaged(page, pageSize, out rowCount)
                .OrderByDescending(p => p.Id)
                //.Select(p => new CatalogItemListItemDto
                //{
                //    Id = p.Id,
                //    Brand = p.CatalogBrand.Brand,
                //    Type = p.CatalogType.Type,
                //    AvailableStock = p.AvailableStock,
                //    MaxStockThreshold = p.MaxStockThreshold,
                //    RestockThreshold = p.RestockThreshold,
                //    Name = p.Name,
                //    Price = p.Price,
                //})
                .AsQueryable();
            if (dto!=null)
            {
              
                if (dto.IsActive==2)
                {
                    data = data.Where(p => p.AvailableStock<=0 || p.IsActive==false).AsQueryable();
                }
                if(dto.IsActive==1)
                {
                    data = data.Where(p => p.IsActive == true).AsQueryable();
                }
                if (dto.CatalogBrandId>0)
                {
                    data = data.Where(p => p.CatalogBrandId == dto.CatalogBrandId).AsQueryable();
                }
                if (dto.CatalogCompanyId>0)
                {
                    data = data.Where(p => p.CatalogCompanyId == dto.CatalogCompanyId).AsQueryable();
                }
                if (dto.CatalogTypeId>0)
                {
                    data = data.Where(p => p.CatalogTypeId == dto.CatalogTypeId).AsQueryable();
                }
                if (dto.CatologCarId>0)
                {
                    data = data.Where(p => p.CatologCarId == dto.CatologCarId).AsQueryable();
                }
                if (!String.IsNullOrEmpty(dto.q))
                {
                    data = data.Where(p => p.Name.Contains(dto.q.Trim()) || p.Slug.Contains(dto.q.Trim())).AsQueryable();
                }
            }

            var model = mapper.ProjectTo<CatalogItemListItemDto>(data).ToList();
            return new PaginatedItemsDto<CatalogItemListItemDto>(page, pageSize, rowCount, model);

        }

        public List<ListCatalogTypeDto> GetCatalogType()
        {
            var types = context.CatalogTypes
               .Include(p => p.ParentCatalogType)
       .Select(p => new ListCatalogTypeDto
       {
           Id = p.Id,
           Type = p.Type,
           ParentId=p.ParentCatalogTypeId
       }).ToList();
            return types;
        }
        public List<ListCatalogTypeDto> GetCatalogTypeWhitParent()
        {
            var types = context.CatalogTypes
               .Include(p => p.ParentCatalogType)
               .Include(p => p.ParentCatalogType)
               .ThenInclude(p => p.ParentCatalogType.ParentCatalogType)
                .Include(p => p.SubType)
                .Where(p => p.ParentCatalogTypeId != null)
                .Where(p => p.SubType.Count == 0)
                 .Select(p => new { p.Id, p.Type, p.ParentCatalogType, p.SubType })
                                .ToList()
                .Select(p => new ListCatalogTypeDto
                {
                    Id = p.Id,
                    Type = $"{p?.Type ?? ""} - {p?.ParentCatalogType?.Type ?? ""} - {p?.ParentCatalogType?.ParentCatalogType?.Type ?? ""}"
                }).ToList();
            return types;
        }
        public PaginatedItemsDto<FavouriteCatalogItemDto> GetMyFavourite(string UserId, int page = 1, int pageSize = 20)
        {
            var model = context.CatalogItems
               .Include(p => p.CatalogItemImages)
               .Include(p => p.Discounts)
               .Include(p => p.CatalogItemFavourites)
               .Where(p => p.CatalogItemFavourites.Any(f => f.UserId == UserId))
               .OrderByDescending(p => p.Id)
               .AsQueryable();
            int rowCount = 0;

            var data = model.PagedResult(page, pageSize, out rowCount)
            .ToList()
            .Select(p => new FavouriteCatalogItemDto
            {
                Id = p.Id,
                Name = p.Name,
                Price = p.Price,
                Rate = 4,
                AvailableStock = p.AvailableStock,
                Slug=p.Slug,
                Image = GlobalConstants.serverImageUrl+p.CatalogItemImages.FirstOrDefault().Src,
            }).ToList();
            return new PaginatedItemsDto<FavouriteCatalogItemDto>(page, pageSize, rowCount, data);
        }

        public List<CarDto> GetCares()
        {
            var cares = context.CatologCars
                 .OrderBy(p => p.Name).Take(500).ToList();
            var data = mapper.Map<List<CarDto>>(cares);
            return data;
        }

        public CatalogItemListItemDto GetCatalogItem(int id)
        {
            var catalog = context.CatalogItems.FirstOrDefault(p => p.Id == id);
            if (catalog!=null)
            {
   var result = mapper.Map<CatalogItemListItemDto>(catalog);
            return result;
            }
            return null;
        }

        public void RemoveMyFavourite(string UserId, int CatalogItemId)
        {
            var catalogItemFavourites = context.CatalogItemFavourites.Where(p=>p.CatalogItemId == CatalogItemId && p.UserId== UserId).FirstOrDefault();
      
            context.CatalogItemFavourites.Remove(catalogItemFavourites);
            context.SaveChanges();
        }

        public async Task ChangeAvailableItem(int id)
        {
            var catalogItem = context.CatalogItems.Where(p => p.Id == id).FirstOrDefault();
            catalogItem.IsActive = !catalogItem.IsActive;
          await  context.SaveChangesAsync();
        }
    }
}
