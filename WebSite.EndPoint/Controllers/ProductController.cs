using Application.Catalogs.CatalogItems.GetCatalogIItemPLP;
using Application.Catalogs.CatalogItems.GetCatalogItemPDP;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSite.EndPoint.Helper;

namespace WebSite.EndPoint.Controllers
{
    public class ProductController : Controller
    {
        private readonly IGetCatalogIItemPLPService getCatalogIItemPLPService;
        private readonly IGetCatalogItemPDPService getCatalogItemPDPService;

        public ProductController(IGetCatalogIItemPLPService
            getCatalogIItemPLPService
            , IGetCatalogItemPDPService getCatalogItemPDPService)
        {
            this.getCatalogIItemPLPService = getCatalogIItemPLPService;
            this.getCatalogItemPDPService = getCatalogItemPDPService;
        }
        public IActionResult Index(CatlogPLPRequestDto catlogPLPRequestDto)
        {
            //if (catlogPLPRequestDto.pageIndex == 1)
            //{
            //    if (true)
            //    {

            //    }
            //    //HttpContext.Session.Remove("CatlogPLP");
            //}
            //SessionHelper.SetObjectAsJson(HttpContext.Session, "CatlogPLP", catlogPLPRequestDto);

            //CatlogPLPRequestDto CatlogPLP = SessionHelper.GetObjectFromJson<CatlogPLPRequestDto>(HttpContext.Session, "productes");

            //ViewBag.IndexSortType = catlogPLPRequestDto.IndexSortType.ToString();
            //var showResolvedFailures = HttpContext.Request.Query["CatalogTypeId"].ToList() ;
            var data = getCatalogIItemPLPService.Execute(catlogPLPRequestDto);
            return View(data);
        }
       [Route("[controller]/[action]/pid-{id}/{slug}")]
        public IActionResult Details(int Id , string slug)
        {
            var data = getCatalogItemPDPService.Execute(Id);
            return View(data);
        }
    }
}
