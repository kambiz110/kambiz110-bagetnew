using Application.Catalogs.CatalogCars.Dto;
using Application.Catalogs.CatalogCompany.Dto;
using Application.Catalogs.CatalohItems.CatalogItemServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ProductListPageService
{
   public class ProductListPageServiceDto
    {
        public List<CatalogBrandDto> BrandDtos { get; set; }
        public List<CompanyDto> companyDtos { get; set; }
        public List<ListCatalogTypeDto> catalogTypeDtos  { get; set; }
        public List<CarDto> CarDtos { get; set; }
    }
}
