using Application.Catalogs.CatalogItems.GetCatalogIItemPLP;
using Application.Catalogs.CatalogItems.GetCatalogItemPDP;
using Application.Comments.Command;
using Application.Comments.Dto;
using DNTCaptcha.Core;
using Ganss.XSS;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSite.EndPoint.Helper;
using WebSite.EndPoint.Utilities;
using WebSite.EndPoint.Utilities.Filters;

namespace WebSite.EndPoint.Controllers
{
    [ServiceFilter(typeof(SaveVisitorFilter))]
    public class ProductController : Controller
    {
        private readonly IGetCatalogIItemPLPService getCatalogIItemPLPService;
        private readonly IGetCatalogItemPDPService getCatalogItemPDPService;
        private readonly IAddCommentService addComment;

        public ProductController(IGetCatalogIItemPLPService
            getCatalogIItemPLPService
            , IGetCatalogItemPDPService getCatalogItemPDPService,
            IAddCommentService _addComment)
        {
            this.getCatalogIItemPLPService = getCatalogIItemPLPService;
            this.getCatalogItemPDPService = getCatalogItemPDPService;
            addComment = _addComment;
        }
        public IActionResult Index(CatlogPLPRequestDto catlogPLPRequestDto)
        {
            var data = getCatalogIItemPLPService.Execute(catlogPLPRequestDto);
            return View(data);
        }
       [Route("[controller]/[action]/pid-{id}/{slug}")]
        public IActionResult Details(int Id , string slug)
        {
            var data = getCatalogItemPDPService.Execute(Id);
            return View(data);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateDNTCaptcha(
           ErrorMessage = "عبارت امنیتی را به درستی وارد نمائید",
           CaptchaGeneratorLanguage = Language.Persian,
           CaptchaGeneratorDisplayMode = DisplayMode.NumberToWord)]
        public IActionResult AddComment(AddCommentDto dto)
        {
            ModelState.Remove("IP");
            ModelState.Remove("commentId");
            ModelState.Remove("UserId");
            if (!ModelState.IsValid)
            {
                var query = from state in ModelState.Values
                            from error in state.Errors
                            select error.ErrorMessage;

                var errorList = query.ToList();
                TempData["errorcomment"] = errorList;
                return Redirect(HttpContext.Request.Headers["Referer"].ToString());
            }
            HtmlSanitizer sanitizer = new HtmlSanitizer();
            dto.Name = sanitizer.Sanitize(dto.Name);
            dto.Message = sanitizer.Sanitize(dto.Message);
            string ip = "";
            if (HttpContext.Connection.RemoteIpAddress != null)
            {
                ip = HttpContext.Connection.RemoteIpAddress.ToString();

            }
            dto.IP = ip;
            string userName = "";
            if (User.Identity.IsAuthenticated)
            {
              dto.UserId = ClaimUtility.GetUserId(User);
                userName = User.Identity.Name;
            }

            var result = addComment.Exequte(dto, userName);
            TempData["Successcomment"] = "پیغام با موفقیت ثبت گردید\n پس از بررسی و در صورت نداشتن محتوای غیر اخلاقی پیغام نمایش داده می شود.";
            var referer = HttpContext.Request.Headers["Referer"].ToString();
            return Redirect(referer);
        }
    }
}
