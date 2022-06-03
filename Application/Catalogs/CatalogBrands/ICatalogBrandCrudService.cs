using Application.Catalogs.CatalohItems.CatalogItemServices;
using Application.Dtos;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Catalogs.CatalogBrands
{
    public  interface ICatalogBrandCrudService
    {
        BaseDto<CatalogBrandDto> Add(CatalogBrandDto catalogCompany);
        BaseDto Remove(int Id);
        BaseDto<CatalogBrandDto> Edit(CatalogBrandDto catalogCompany);
        BaseDto<CatalogBrandDto> FindById(int Id);
        PaginatedItemsDto<CatalogBrandDto> GetList(int page, int pageSize);
    }
}
