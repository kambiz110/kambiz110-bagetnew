using Application.Catalogs.CatalohItems.CatalogItemServices;
using Application.Dtos;
using Application.Interfaces.Contexts;
using AutoMapper;
using Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Application.Catalogs.CatalogBrands
{
    public class CatalogBrandCrudService : ICatalogBrandCrudService
    {
        private readonly IDataBaseContext context;
        private readonly IMapper mapper;

        public CatalogBrandCrudService(IDataBaseContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        public BaseDto<CatalogBrandDto> Add(CatalogBrandDto dto)
        {
            var model = mapper.Map<Domain.Catalogs.CatalogBrand>(dto);
            context.CatalogBrands.Add(model);
            context.SaveChanges();
            return new BaseDto<CatalogBrandDto>
               (
               true,
               new List<string> { $"برند {model.Brand}  با موفقیت در سیستم ثبت شد" },
                mapper.Map<CatalogBrandDto>(model)
             );
        }

        public BaseDto<CatalogBrandDto> Edit(CatalogBrandDto dto)
        {
            var model = context.CatalogBrands.SingleOrDefault(p => p.Id == dto.Id);
            mapper.Map(dto, model);
            context.SaveChanges();
            return new BaseDto<CatalogBrandDto>
              (
               true,
                new List<string> { $"برند {model.Brand} با موفقیت ویرایش شد" },

                mapper.Map<CatalogBrandDto>(model)
              );
        }

        public BaseDto<CatalogBrandDto> FindById(int Id)
        {
            var data = context.CatalogBrands.Find(Id);
            var result = mapper.Map<CatalogBrandDto>(data);

            return new BaseDto<CatalogBrandDto>(
                true,
                null,
                result
                );
        }

        public PaginatedItemsDto<CatalogBrandDto> GetList(int page, int pageSize)
        {
            int totalCount = 0;
            var model = context.CatalogBrands
                .PagedResult(page, pageSize, out totalCount);
            var result = mapper.ProjectTo<CatalogBrandDto>(model).ToList();
            return new PaginatedItemsDto<CatalogBrandDto>(page, pageSize, totalCount, result);
        }

        public BaseDto Remove(int Id)
        {
            var CatalogBrand = context.CatalogBrands.Find(Id);
            context.CatalogBrands.Remove(CatalogBrand);
            context.SaveChanges();
            return new BaseDto
            (
             true,
             new List<string> { $"برند با موفقیت حذف شد" }
             );
        }
    }
}
