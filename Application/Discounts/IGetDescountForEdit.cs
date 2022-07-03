using Application.Discounts.Dto;
using Application.Dtos;
using Application.Interfaces.Contexts;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Discounts
{
   public interface IGetDescountForEdit
    {
        BaseDto<GetDescountsForEditViewModel> GetDescount(int id);
    }
    public class GetDescountForEdit : IGetDescountForEdit
    {
        private readonly IDataBaseContext _context;
        private readonly IMapper _mapper;

        public GetDescountForEdit(IDataBaseContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public BaseDto<GetDescountsForEditViewModel> GetDescount(int id)
        {
            var descount = _context.Discount.Where(p => p.Id == id)
                .AsNoTracking()
                .Include(p => p.CatalogItems).FirstOrDefault();
            if (descount!=null)
            {
                var model = _mapper.Map<GetDescountsForEditViewModel>(descount);
                return new BaseDto<GetDescountsForEditViewModel>(true, new List<string> { "موفق" }, model);
            }
            return new BaseDto<GetDescountsForEditViewModel>(false, new List<string> { "ناموفق"}, null);
        }
    }
}
