using Application.Catalogs.CatalogCars.Dto;

using Application.Dtos;
using Application.Interfaces.Contexts;
using AutoMapper;
using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Catalogs.CatalogCars.CrudService
{
    public class CrudCarService : ICrudCarService
    {
        private readonly IDataBaseContext context;
        private readonly IMapper mapper;

        public CrudCarService(IDataBaseContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        public BaseDto<CarDto> Add(CarDto catalogCar)
        {
            var model = mapper.Map<Domain.Catalogs.CatologCar>(catalogCar);
            context.CatologCars.Add(model);
            context.SaveChanges();
            return new BaseDto<CarDto>
               (
               true,
               new List<string> { $"خودرو {model.Name}  با موفقیت در سیستم ثبت شد" },
                mapper.Map<CarDto>(model)
             );
    
        }

        public BaseDto<CarDto> Edit(CarDto catalogCar)
        {
            var model = context.CatologCars.SingleOrDefault(p => p.Id == catalogCar.Id);
            mapper.Map(catalogCar, model);
            context.SaveChanges();
            return new BaseDto<CarDto>
              (
               true,
                new List<string> { $"خودرو {model.Name} با موفقیت ویرایش شد" },

                mapper.Map<CarDto>(model)
              );
        }

        public BaseDto<CarDto> FindById(int Id)
        {
            var data = context.CatologCars.Find(Id);
            var result = mapper.Map<CarDto>(data);

            return new BaseDto<CarDto>(
                true,
                null,
                result
                );
        }

        public PaginatedItemsDto<CarListDto> GetList( int page, int pageSize)
        {
            int totalCount = 0;
            var model = context.CatologCars
                .PagedResult(page, pageSize, out totalCount);
            var result = mapper.ProjectTo<CarListDto>(model).ToList();
            return new PaginatedItemsDto<CarListDto>(page, pageSize, totalCount, result);
        }

        public BaseDto Remove(int Id)
        {
            var catalogCar = context.CatologCars.Find(Id);
            context.CatologCars.Remove(catalogCar);
            context.SaveChanges();
            return new BaseDto
            (
             true,
             new List<string> { $"خودرو با موفقیت حذف شد" }
             );
        }
    }
}
