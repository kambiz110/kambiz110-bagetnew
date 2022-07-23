using Application.Interfaces.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Discounts
{
   public interface IDeletedDiscount
    {
        void Exequte(int id);
    }
   public class DeletedDiscount : IDeletedDiscount
    {
        private readonly IDataBaseContext context;

        public DeletedDiscount( IDataBaseContext _context)
        {
            context = _context;
        }

        public void Exequte(int id)
        {
            var discunt = context.Discount.Where(p=>p.Id==id)
                
                //.Include(p=>p.CatalogItems)
                .FirstOrDefault();
            if (discunt!=null)
            {
                context.Discount.Remove(discunt);
               var resultSaved= context.SaveChanges();
            }
        }
    }
}
