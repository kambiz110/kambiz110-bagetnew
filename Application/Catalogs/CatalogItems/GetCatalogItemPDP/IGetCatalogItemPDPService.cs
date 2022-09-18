using Application.Catalogs.CatalogItems.UriComposer;
using Application.Interfaces.Contexts;
using Common.Useful;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Catalogs.CatalogItems.GetCatalogItemPDP
{
    public interface IGetCatalogItemPDPService
    {
        CatalogItemPDPDto Execute(int Id);
    }

    public class GetCatalogItemPDPService : IGetCatalogItemPDPService
    {
        private readonly IDataBaseContext context;
      

        public GetCatalogItemPDPService(IDataBaseContext context )
        {
            this.context = context;
           
        }
        public CatalogItemPDPDto Execute(int Id)
        {
            var catalogitem = context.CatalogItems

                .Include(p => p.CatalogItemFeatures)
                .Include(p => p.CatalogItemImages)
                 .Include(p => p.CatalogBrand)
                .Include(p => p.CatalogCompany)
                .Include(p => p.CatalogType)
                .Include(p => p.CatologCar)
                .Include(p => p.Discounts)
                .SingleOrDefault(p => p.Id == Id);
            if (catalogitem==null)
            {
                return null;
            }
            catalogitem.VisitCount += 1;
            catalogitem.LastVisitDate =DateTime.Now;
            context.SaveChanges();

            var feature = catalogitem.CatalogItemFeatures
                .Select(p => new PDPFeaturesDto
                {
                    Group = p.Group,
                    Key = p.Key,
                    Value = p.Value
                }).ToList()
                .GroupBy(p => p.Group);

            var similarCatalogItems = context
               .CatalogItems
               .Include(p => p.CatalogItemImages)
               .Include(p => p.Discounts)
               .Where(p => p.CatalogTypeId == catalogitem.CatalogTypeId)
               .Take(10)
               .Select(p => new SimilarCatalogItemDto
               {
                   Id = p.Id,
                   Image = GlobalConstants.serverImageUrl + p.CatalogItemImages.FirstOrDefault().Src,
                   Price = p.Price,
                   Name = p.Name,
                   DiscountPercentage = p.Discounts.Count > 0 ? p.Discounts.OrderByDescending(p => p.DiscountPercentage).FirstOrDefault().DiscountPercentage : 0,
                   Rate = 5,
                   OldPrice = p.OldPrice ?? p.Price,
                   AvailableStock = p.AvailableStock,
                   Slug = p.Slug,
               }).ToList();

            return new CatalogItemPDPDto
            {
                Features = feature,
                SimilarCatalogs = similarCatalogItems,
                Id = catalogitem.Id,
                Name = catalogitem.Name,
                Rate = 5,
                Slug = catalogitem.Slug,
                Brand = catalogitem.CatalogBrand.Brand,
                Type = catalogitem.CatalogType.Type,
                Price = catalogitem.Price,
                Description = catalogitem.Description,
                Images = catalogitem.CatalogItemImages.Select(p => GlobalConstants.serverImageUrl + (p.Src)).ToList(),
                OldPrice = catalogitem.OldPrice ?? catalogitem.Price,
                PercentDiscount = catalogitem.PercentDiscount,
                CarName = catalogitem.CatologCar.Name,
                CompanyName = catalogitem.CatalogCompany.Name,
                TypeName = catalogitem.CatalogType.Type,
                BrrndName = catalogitem.CatalogBrand.Brand,
                IsActive=catalogitem.IsActive,
            };


        }
    }

    public class CatalogItemPDPDto
    {
        public int Id { get; set; }
        public int Rate { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Brand { get; set; }
        public string Slug { get; set; }
        public int Price { get; set; }
        public int? OldPrice { get; set; }
        public int? PercentDiscount { get; set; }
        public List<string> Images { get; set; }
        public string Description { get; set; }
        public string TypeName { get; set; }
        public string CarName { get; set; }
        public string BrrndName { get; set; }
        public string CompanyName { get; set; }
        public bool IsActive { get; set; }
        public IEnumerable<IGrouping<string, PDPFeaturesDto>> Features { get; set; }
        public List<SimilarCatalogItemDto> SimilarCatalogs { get; set; }

    }

    public class PDPFeaturesDto
    {
        public string Group { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
    }


    public class SimilarCatalogItemDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Image { get; set; }
        public int DiscountPercentage { get; set; }
        public byte Rate { get; set; }
        public int AvailableStock { get; set; }
        public int? OldPrice { get; set; }
        public string Slug { get; set; }
    }
}
