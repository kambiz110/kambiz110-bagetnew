using Application.Catalogs.CatalogCars.Dto;
using Application.Catalogs.CatalogCompany.Dto;
using Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Catalogs.CatalogCars.CrudService
{
    public interface ICrudCarService
    {
        BaseDto<CarDto> Add(CarDto catalogCompany);
        BaseDto Remove(int Id);
        BaseDto<CarDto> Edit(CarDto catalogCompany);
        BaseDto<CarDto> FindById(int Id);
        PaginatedItemsDto<CarListDto> GetList( int page, int pageSize);
  
    }
}
