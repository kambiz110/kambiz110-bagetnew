using Application.Interfaces.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Discounts
{
   public interface IDeletItemInDescount
    {
        bool delete(int descountId , int categoriItemId);
    }
    public class DeletItemInDescount : IDeletItemInDescount
    {
        private readonly IDataBaseContext _context;

        public DeletItemInDescount(IDataBaseContext context)
        {
            _context = context;
        }

        public bool delete(int descountId, int categoriItemId)
        {
            var descountItem = _context.Discount.Where(p => p.Id == descountId).Include(p=>p.CatalogItems).FirstOrDefault();
            if (descountItem != null)
            {
                foreach (var item in descountItem.CatalogItems.Where(p=>p.Id== categoriItemId).ToList())
                {
                    descountItem.CatalogItems.Remove(item);
                }
                this._context.SaveChanges();
            }
            return true;
        }
    }
}
