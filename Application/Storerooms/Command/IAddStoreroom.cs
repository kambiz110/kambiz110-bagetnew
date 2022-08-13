using Application.Interfaces.Contexts;
using Application.Storerooms.Dto;
using Domain.Catalogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Storerooms.Command
{
   public interface IAddStoreroom
    {
        bool add(AddStoreroomDto dto);
    }
    public class AddStoreroom : IAddStoreroom
    {
        private readonly IDataBaseContext context;

        public AddStoreroom(IDataBaseContext context)
        {
            this.context = context;
        }

        public bool add(AddStoreroomDto dto)
        {
            Storeroom dbObj = new Storeroom();
            dbObj.CatalogItemId = dto.CatalogItemId;
            dbObj.StockCount = dto.StockCount;
            dbObj.UserId = dto.UserId;
            dbObj.Status = (StoreroomStatus)dto.Status;
            context.Storerooms.Add(dbObj);
            var result = context.SaveChanges();
            return result > 0 ? true : false;
        }
    }
}
