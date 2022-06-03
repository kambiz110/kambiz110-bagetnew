using Application.Catalogs.CatalogCompany.Dto;
using Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Catalogs.CatalogCompany.CrudService
{
    public interface ICrudCompanyService
    {
        BaseDto<CompanyDto> Add(CompanyDto catalogCompany);
        BaseDto Remove(int Id);
        BaseDto<CompanyDto> Edit(CompanyDto catalogCompany);
        BaseDto<CompanyDto> FindById(int Id);
        PaginatedItemsDto<CompanyListDto> GetList( int page, int pageSize);
  
    }
}
