using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.EndPoint.Binders;
using Application.Catalogs.CatalohItems.CatalogItemServices;
using Application.Discounts.AddNewDiscountServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Admin.EndPoint.Pages.Discounts
{
    public class CreateModel : PageModel
    {
        private readonly IAddNewDiscountService addNewDiscountService;
        private readonly ICatalogItemService catalogItemService;

        public CreateModel(IAddNewDiscountService addNewDiscountService, ICatalogItemService catalogItemService)
        {
            this.addNewDiscountService = addNewDiscountService;
            this.catalogItemService = catalogItemService;
        }

        //[ModelBinder(BinderType = typeof(DiscountEntityBinder))]
        [BindProperty]
        public AddNewDiscountDto model { get; set; }
        public SelectList Categories { get; set; }
        public SelectList Brands { get; set; }
        public void OnGet()
        {
            Categories = new SelectList(catalogItemService.GetCatalogType(), "Id", "Type");
            Brands = new SelectList(catalogItemService.GetBrand(), "Id", "Brand");
        }

        public void OnPost()
        {
            addNewDiscountService.Execute(model);
        }
    }
}
