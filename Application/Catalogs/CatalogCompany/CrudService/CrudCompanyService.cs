using Application.Catalogs.CatalogCompany.Dto;
using Application.Dtos;
using Application.Interfaces.Contexts;
using AutoMapper;
using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Catalogs.CatalogCompany.CrudService
{
    public class CrudCompanyService : ICrudCompanyService
    {
        private readonly IDataBaseContext context;
        private readonly IMapper mapper;

        public CrudCompanyService(IDataBaseContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        public BaseDto<CompanyDto> Add(CompanyDto catalogCompany)
        {
            var model = mapper.Map<Domain.Catalogs.CatalogCompany>(catalogCompany);
            context.CatalogCompanes.Add(model);
            context.SaveChanges();
            return new BaseDto<CompanyDto>
               (
               true,
               new List<string> { $"کمپانی {model.Name}  با موفقیت در سیستم ثبت شد" },
                mapper.Map<CompanyDto>(model)
             );
            throw new NotImplementedException();
        }

        public BaseDto<CompanyDto> Edit(CompanyDto catalogCompany)
        {
            var model = context.CatalogCompanes.SingleOrDefault(p => p.Id == catalogCompany.Id);
            mapper.Map(catalogCompany, model);
            context.SaveChanges();
            return new BaseDto<CompanyDto>
              (
               true,
                new List<string> { $"تایپ {model.Name} با موفقیت ویرایش شد" },

                mapper.Map<CompanyDto>(model)
              );
        }

        public BaseDto<CompanyDto> FindById(int Id)
        {
            var data = context.CatalogCompanes.Find(Id);
            var result = mapper.Map<CompanyDto>(data);

            return new BaseDto<CompanyDto>(
                true,
                null,
                result
                );
        }

        public PaginatedItemsDto<CompanyListDto> GetList( int page, int pageSize)
        {
            int totalCount = 0;
            var model = context.CatalogCompanes
                .PagedResult(page, pageSize, out totalCount);
            var result = mapper.ProjectTo<CompanyListDto>(model).ToList();
            return new PaginatedItemsDto<CompanyListDto>(page, pageSize, totalCount, result);
        }

        public BaseDto Remove(int Id)
        {
            var catalogCompany = context.CatalogCompanes.Find(Id);
            context.CatalogCompanes.Remove(catalogCompany);
            context.SaveChanges();
            return new BaseDto
            (
             true,
             new List<string> { $"ایتم با موفقیت حذف شد" }
             );
        }
    }
}
