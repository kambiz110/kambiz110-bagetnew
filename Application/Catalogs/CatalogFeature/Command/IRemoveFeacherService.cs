using Application.Catalogs.CatalogFeature.Dto;
using Application.Dtos;
using Application.Interfaces.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Catalogs.CatalogFeature.Command
{
    public interface IRemoveFeacherService
    {
        BaseDto Exequte(RemoveFeatureDto dto);
    }
    public class RemoveFeacherService : IRemoveFeacherService
    {
        private readonly IDataBaseContext context;

        public RemoveFeacherService(IDataBaseContext context)
        {
            this.context = context;

        }

        public BaseDto Exequte(RemoveFeatureDto dto)
        {
            var model = context.CatalogItemFeatures.AsNoTracking().Where(p => p.CatalogItemId == dto.itemid && p.Key == dto.Key && p.Value == dto.Value).FirstOrDefault();
            if (model != null)
            {
                context.CatalogItemFeatures.Remove(model);
                var result = context.SaveChanges();
                if (result > 0)
                {
                    return new BaseDto
                              (
                               true,
                                new List<string> { $" با موفقیت حذف شد" }
                              );
                }
            }

            return new BaseDto
             (
              false,
               new List<string> { $" ناموفق  " }
             );
        }
    }
}
