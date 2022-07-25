using Application.Catalogs.CatalogCars.Dto;
using Application.Catalogs.CatalogCompany.Dto;
using Application.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;

namespace Application.Catalogs.CatalohItems.CatalogItemServices
{
    public interface ICatalogItemService
    {
        List<CarDto> GetCares();
        List<CompanyDto> GetCompanes();
        List<CatalogBrandDto> GetBrand();
        List<ListCatalogTypeDto> GetCatalogType();
        PaginatedItemsDto<CatalogItemListItemDto> GetCatalogList(int page, int pageSize , SearchInCategoreItemsDto dto);

        void AddToMyFavourite(string UserId, int CatalogItemId);
        PaginatedItemsDto<FavouriteCatalogItemDto> GetMyFavourite(string UserId, int page = 1, int pageSize = 20);

    }


    public class FavouriteCatalogItemDto
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public int Rate { get; set; }
        public int AvailableStock { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
    }


    public class CatalogBrandDto
    {
        public int Id { get; set; }
        [Display(Name = "نام برند")]
        public string Brand { get; set; }


        [Display(Name = "مسیر عکس ")]
        public string Src { get; set; }
        public bool IsDakely { get; set; }
    }
    public class ListCatalogTypeDto
    {
        public int Id { get; set; }
        public string Type { get; set; }
    }

    public class CatalogItemListItemDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Type { get; set; }
        public string Brand { get; set; }
        public int AvailableStock { get; set; }
        public int RestockThreshold { get; set; }
        public int MaxStockThreshold { get; set; }
    }
    public class SearchInCategoreItemsDto
    {
        public int CatalogTypeId { get; set; }
        public int CatalogBrandId { get; set; }
        public int CatologCarId { get; set; }
        public int CatalogCompanyId { get; set; }
        public string q { get; set; } = "";
    }
}
