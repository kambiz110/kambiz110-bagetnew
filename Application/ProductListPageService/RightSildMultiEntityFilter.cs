using Application.Catalogs.CatalohItems.CatalogItemServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ProductListPageService
{
    /// <summary>
    /// لیست فیلترهای برند، کمپانی، دسته بندی و نوع خودرو
    /// </summary>
    public interface IRightSildMultiEntityFilter
    {
        ProductListPageServiceDto Exequted();
    }
    public class RightSildMultiEntityFilter : IRightSildMultiEntityFilter
    {
        private readonly ICatalogItemService catalogItemService;

        public RightSildMultiEntityFilter(ICatalogItemService catalogItemService)
        {
            this.catalogItemService = catalogItemService;
        }

        public ProductListPageServiceDto Exequted()
        {
            ProductListPageServiceDto model = new ProductListPageServiceDto();
            model.BrandDtos = catalogItemService.GetBrand();
            model.CarDtos = catalogItemService.GetCares();
            model.companyDtos = catalogItemService.GetCompanes();
            model.catalogTypeDtos = catalogItemService.GetCatalogType();


            return model;
        }
    }
}
