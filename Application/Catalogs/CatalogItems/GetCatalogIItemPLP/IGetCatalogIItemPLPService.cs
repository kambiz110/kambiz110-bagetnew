using Application.Catalogs.CatalogItems.UriComposer;
using Application.Dtos;
using Application.Interfaces.Contexts;
using Common;
using Common.Useful;
using Domain.Order;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Catalogs.CatalogItems.GetCatalogIItemPLP
{
    public interface IGetCatalogIItemPLPService
    {
        PaginatedItemsDto<CatalogPLPDto> Execute(CatlogPLPRequestDto request);
    }

    public class GetCatalogIItemPLPService : IGetCatalogIItemPLPService
    {
        private readonly IDataBaseContext context;
       

        public GetCatalogIItemPLPService(IDataBaseContext context
           )
        {
            this.context = context;
           
        }
        public PaginatedItemsDto<CatalogPLPDto> Execute(CatlogPLPRequestDto request)
        {
            int rowCount = 0;
            var query = context.CatalogItems.Where(p => p.IsActive == true).AsNoTracking()
                .Include(p => p.Discounts).AsNoTracking()
                .Include(p => p.CatalogItemImages)
                .Include(p => p.CatalogBrand)
                .Include(p => p.CatalogCompany)
                .Include(p => p.CatalogType)
                .Include(p => p.CatologCar)
                .OrderByDescending(p => p.Id)
                .AsQueryable();

            if (request.brandId != null)
            {
                query = query.Where(p => request.brandId.Contains( p.CatalogBrandId));
            }

            if (request.CatalogTypeId != null)
            {
                var serchLST = request.CatalogTypeId.Where(p => p != 0).ToArray();
                if (serchLST.Length>0)
                {
                query = query.Where(p => serchLST.Contains(p.CatalogTypeId));
                }
               
            }
            if (request.CatalogCopmanyId != null)
            {
                query = query.Where(p => p.CatalogCompanyId == request.CatalogCopmanyId);
            }
            if (request.CatalogCarId != null)
            {
                query = query.Where(p => p.CatologCarId == request.CatalogCarId);
            }

            if (!string.IsNullOrEmpty(request.SearchKey))
            {
                query = query.Where(p => p.Name.Contains(request.SearchKey)
                || p.Description.Contains(request.SearchKey));
            }

            if (request.AvailableStock == true)
            {
                query = query.Where(p => p.AvailableStock > 0);
            }

            if ((int)request.SortType == 1 /*SortType.MostVisited*/)
            {
                query = query
                    .OrderByDescending(p => p.VisitCount);
            }
            if ((int)request.SortType == 2 /*SortType.Bestselling*/)
            {
                query = query
                  .OrderByDescending(p => p.Selered);
            }

            if ((int)request.SortType == 3 /*SortType.MostPopular*/)
            {
                query = query.Include(p => p.CatalogItemFavourites)
                    .OrderByDescending(p => p.CatalogItemFavourites.Count());
            }


            if ((int)request.SortType == 4 /*SortType.newes*/)
            {
                query = query
                    .OrderByDescending(p => p.Id);
            }

            if ((int)request.SortType == 5 /*SortType.cheapest*/)
            {
                query = query
                    .Include(p => p.Discounts)
                    .OrderBy(p => p.Price);
            }

            if ((int)request.SortType == 6 /*SortType.mostExpensive*/)
            {
                query = query
                    .Include(p => p.Discounts)
                    .OrderByDescending(p => p.Price);
            }

            if ((int)request.SortType == 7/*SortType.mostDescounted*/)
            {
                query = query
                    .Include(p => p.Discounts)
                        .Where(p => p.Discounts.Count() > 0);
            }
            if (query != null && query.Any())
            {
                var result = query.PagedResult(request.pageIndex, request.page,  out rowCount)
                       .ToList();
                if (result.Count > 0)
                {
                    var data = result.Select(p => new CatalogPLPDto
                    {
                        Id = p.Id,
                        Name = p.Name,
                        Price = p.Price,
                        OldPrice = p.OldPrice,
                        Description = p.Description,
                        Slug = p.Slug,
                        CarName = p.CatologCar.Name,
                        CompanyName = p.CatalogCompany.Name,
                        TypeName = p.CatalogType.Type,
                        BrrndName = p.CatalogBrand.Brand,
                        DiscountPercentage = p.Discounts.Count > 0 ? p.Discounts.OrderByDescending(p => p.DiscountPercentage).FirstOrDefault().DiscountPercentage : 0,
                        Rate = 4,
                        Images = p.CatalogItemImages.Select(p => GlobalConstants.serverImageUrl + p.Src).ToList(),
                        AvailableStock = p.AvailableStock,
                    }).ToList();
                    return new PaginatedItemsDto<CatalogPLPDto>(request.pageIndex, request.page, rowCount, data);

                }
            }

            return new PaginatedItemsDto<CatalogPLPDto>(request.page, request.pageIndex, rowCount, new List<CatalogPLPDto>());
        }
    }


    public class CatlogPLPRequestDto
    {
        public int priceMin { get; set; }
        public int priceMax { get; set; }

        public int page { get; set; } = 12;
        public int pageIndex { get; set; } = 1;
        public int? CatalogCarId { get; set; }
        public int? CatalogCopmanyId { get; set; }
        public int[] CatalogTypeId { get; set; }
        public int[] brandId { get; set; }
        public bool AvailableStock { get; set; }
        public string SearchKey { get; set; }
        public int IndexSortType { get; set; }
        public SortType SortType { get; set; }
      }


    public enum SortType
    {
        /// <summary>
        /// بدونه مرتب سازی
        /// </summary>
        None = 0,
        /// <summary>
        /// پربازدیدترین
        /// </summary>
        MostVisited = 1,
        /// <summary>
        /// پرفروش‌ترین
        /// </summary>
        Bestselling = 2,
        /// <summary>
        /// محبوب‌ترین
        /// </summary>
        MostPopular = 3,
        /// <summary>
        ///  ‌جدیدترین
        /// </summary>
        newest = 4,
        /// <summary>
        /// ارزان‌ترین
        /// </summary>
        cheapest = 5,
        /// <summary>
        /// گران‌ترین
        /// </summary>
        mostExpensive = 6,
        /// <summary>
        /// ‌بیشترین تخفیف
        /// </summary>
        mostDescounted = 7,
    }

    public class CatalogPLPDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Slug { get; set; }
        public int DiscountPercentage { get; set; }
        public string Description { get; set; }
        public int? OldPrice { get; set; }
        public List<string> Images { get; set; }
        public byte Rate { get; set; }
        public int AvailableStock { get; set; }
        public string TypeName { get; set; }
        public string CarName { get; set; }
        public string CompanyName { get; set; }
        public string BrrndName { get; set; }
    }
}
