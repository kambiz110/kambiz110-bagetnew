using Application.Catalogs.CatalogItems.GetCatalogIItemPLP;
using Application.Catalogs.CatalogItems.UriComposer;
using Application.Interfaces.Contexts;
using Domain.Banners;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.HomePageService
{
    public interface IHomePageService
    {
        HomePageDto GetData();
    }

    public class HomePageService : IHomePageService
    {
        private readonly IDataBaseContext context;
        private readonly IUriComposerService uriComposerService;
        private readonly IGetCatalogIItemPLPService getCatalogIItemPLPService;

        public HomePageService(IDataBaseContext context
            , IUriComposerService uriComposerService
            , IGetCatalogIItemPLPService getCatalogIItemPLPService)
        {
            this.context = context;
            this.uriComposerService = uriComposerService;
            this.getCatalogIItemPLPService = getCatalogIItemPLPService;
        }


        public HomePageDto GetData()
        {
            //var banners = context.Banners.Where(p => p.IsActive == true)
            //    .OrderBy(p => p.Priority)
            //    .ThenByDescending(p => p.Id)
            //    .Select(p => new BannerDto
            //    {
            //        Id = p.Id,
            //        Image = uriComposerService.ComposeImageUri(p.Image),
            //        Link = p.Link,
            //        Position = p.Position,
            //    }).ToList();

            var Bestselling = getCatalogIItemPLPService.Execute(new CatlogPLPRequestDto
            {
                AvailableStock = true,
                page = 1,
                pageSize = 20,
                SortType = SortType.Bestselling
            }).Data.ToList();

            var MostPopular = getCatalogIItemPLPService.Execute(new CatlogPLPRequestDto
            {
                AvailableStock = true,
                page = 1,
                pageSize = 20,
                SortType = SortType.MostPopular
            }).Data.ToList();


            List<CatalogPLPDto> MostDescountNumber = new List<CatalogPLPDto>();
            var DiscountCatalogItem = context.Discount
                .Where(p => p.DiscountPercentage != 0)
                .OrderByDescending(p => p.Id)
                .Include(p => p.CatalogItems).ThenInclude(p => p.CatalogItemImages)
                .ToList();
            if (DiscountCatalogItem!=null && DiscountCatalogItem.Count()>0)
            {

                foreach (var item in DiscountCatalogItem)
                {
                    MostDescountNumber.AddRange(item.CatalogItems.Select(p => new CatalogPLPDto {
                    Id=p.Id,
                    Price=p.Price,
                    Rate=4,
                    AvailableStock=p.AvailableStock,
                    Image= uriComposerService
                    .ComposeImageUri(p.CatalogItemImages.FirstOrDefault()?.Src)
                }));
                }
            }
            return new HomePageDto
            {
                MostDescountNumber = MostDescountNumber,
                bestSellers = Bestselling,
                MostPopular = MostPopular,
            };
        }
    }

    public class HomePageDto
    {
       
        public List<CatalogPLPDto> MostDescountNumber { get; set; }
        public List<CatalogPLPDto> MostPopular { get; set; }
        public List<CatalogPLPDto> bestSellers { get; set; }


    }

    public class BannerDto
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Link { get; set; }
        public Position Position { get; set; }
    }
}
