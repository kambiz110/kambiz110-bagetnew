using Application.Dtos;
using Application.Interfaces.Contexts;
using AutoMapper;
using Common;
using Domain.Catalogs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Catalogs.CatalogTypeImages
{
    public interface ICRUDCatalogTypeImage
    {
        BaseDto<CatalogTypeImageDto> Add(CatalogTypeImageDto catalogType);
        BaseDto Remove(int Id);
        BaseDto RemoveCatalogTypeId(int Id);
        BaseDto<CatalogTypeImageDto> Edit(CatalogTypeImageDto catalogType);
        BaseDto<CatalogTypeImageDto> FindById(int Id);
        BaseDto<CatalogTypeImageDto> FindByCatalogTypeId(int Id);
        PaginatedItemsDto<CatalogTypeImageDto> GetList(int? parentId, int page, int pageSize);
    }
    public class CRUDCatalogTypeImage : ICRUDCatalogTypeImage
    {
        private readonly IDataBaseContext context;
        private readonly IMapper mapper;

        public CRUDCatalogTypeImage(IDataBaseContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        public BaseDto<CatalogTypeImageDto> Add(CatalogTypeImageDto catalogType)
        {
            var model = mapper.Map(catalogType,new CatalogTypeImage() { } );

            context.CatalogTypeImages.Add(model);
            var resultsave = context.SaveChanges();
            return new BaseDto<CatalogTypeImageDto>
               (
               true,
               new List<string> { $" با موفقیت در سیستم ثبت شد" },
                mapper.Map<CatalogTypeImageDto>(model)
             );
        }

        public BaseDto<CatalogTypeImageDto> Edit(CatalogTypeImageDto catalogType)
        {
            var model = context.CatalogTypeImages.SingleOrDefault(p => p.Id == catalogType.Id);
            mapper.Map(catalogType, model);
            context.SaveChanges();
            return new BaseDto<CatalogTypeImageDto>
              (
               true,
                new List<string> { $"  با موفقیت ویرایش شد" },

                mapper.Map<CatalogTypeImageDto>(model)
              );
        }

        public BaseDto<CatalogTypeImageDto> FindById(int Id)
        {
            var data = context.CatalogTypeImages.Find(Id);
            var result = mapper.Map<CatalogTypeImageDto>(data);

            return new BaseDto<CatalogTypeImageDto>(
                true,
                null,
                result
                );
        }
        public BaseDto<CatalogTypeImageDto> FindByCatalogTypeId(int Id)
        {
            var data = context.CatalogTypeImages.AsNoTracking().Where(p => p.CatalogTypeId == Id).FirstOrDefault();
            var result = mapper.Map<CatalogTypeImageDto>(data);

            return new BaseDto<CatalogTypeImageDto>(
                true,
                null,
                result
                );
        }

        public PaginatedItemsDto<CatalogTypeImageDto> GetList(int? parentId, int page, int pageSize)
        {
            int totalCount = 0;
            var model = context.CatalogTypeImages.AsNoTracking()
                .PagedResult(page, pageSize, out totalCount);
            var result = mapper.ProjectTo<CatalogTypeImageDto>(model).ToList();
            return new PaginatedItemsDto<CatalogTypeImageDto>(page, pageSize, totalCount, result);
        }

        public BaseDto Remove(int Id)
        {
            var catalogTypeImage = context.CatalogTypeImages.Find(Id);
            if (catalogTypeImage != null)
            {
                context.CatalogTypeImages.Remove(catalogTypeImage);
                context.SaveChanges();
            }

            return new BaseDto
            (
             true,
             new List<string> { $"ایتم با موفقیت حذف شد" }
             );
        }

        public BaseDto RemoveCatalogTypeId(int Id)
        {
            var catalogType = context.CatalogTypeImages.AsNoTracking().Where(p => p.CatalogTypeId == Id).FirstOrDefault();
            if (catalogType != null)
            {
                context.CatalogTypeImages.Remove(catalogType);
                context.SaveChanges();
            }

            return new BaseDto
            (
             true,
             new List<string> { $"ایتم با موفقیت حذف شد" }
             );
        }
    }
    public class CatalogTypeImageDto
    {
        public int Id { get; set; }
        public string Src { get; set; }
        public int CatalogTypeId { get; set; }

    }
}
