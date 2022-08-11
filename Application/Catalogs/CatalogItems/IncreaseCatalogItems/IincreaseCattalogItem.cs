using Application.Interfaces.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Catalogs.CatalogItems.IncreaseCatalogItems
{
   public interface IincreaseCattalogItem
    {
        bool addStock(int id, int count);
    }
    public class increaseCattalogItem : IincreaseCattalogItem
    {
        private readonly IDataBaseContext context;

        public increaseCattalogItem(IDataBaseContext context)
        {
            this.context = context;
        }

        public bool addStock(int id ,int count)
        {
            var catalog = context.CatalogItems.FirstOrDefault(p=>p.Id==id);
            if (catalog!=null)
            {
                catalog.AvailableStock += count;
            var result=    context.SaveChanges();
                return result>0? true:false;
            }
            return false;
        }
    }
}
