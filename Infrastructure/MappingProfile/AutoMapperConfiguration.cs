using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.MappingProfile
{
  public  class AutoMapperConfiguration
    {
        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new BannerMapperProfile());
                cfg.AddProfile(new CatalogMappingProfile());
                cfg.AddProfile(new CatalogTypeMapperProfile());
                cfg.AddProfile(new DescountMapperProfile());
                cfg.AddProfile(new UserMappingProfile());
                cfg.AddProfile(new PostalProductMappingProfile());
                cfg.AddProfile(new ReturnPaymentInvoiceProfile());
            });
        }
    }
}
