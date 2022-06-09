using Application.Dtos;
using Application.Interfaces.Contexts;
using Common.Useful;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Catalogs.CatalogItems.RemoveImage
{
   public interface IDeleteImageService
    {
        ResultDto delete(int itemId, string src);
    }
    public class DeleteImageService : IDeleteImageService
    {
        private readonly IDataBaseContext context;

        public DeleteImageService(IDataBaseContext context)
        {
            this.context = context;
        }

        public ResultDto delete(int itemId, string src)
        { var srcc = src.Replace(GlobalConstants.serverImageUrl, "");
            var img = context.CatalogItemImage.Where(p => p.CatalogItemId == itemId && p.Src == srcc).FirstOrDefault();
            if (img!=null)
            {
                context.CatalogItemImage.Remove(img);
                var result = context.SaveChanges();
                if (result>0)
                {
                    return new ResultDto{
                        IsSuccess= true
                       
                    };
                }
            }
            return new ResultDto {IsSuccess=false };
        }
    }
}
