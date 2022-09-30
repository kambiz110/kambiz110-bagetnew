using Application.Catalogs.CatalogItems.GetCatalogIItemPLP;
using Application.Catalogs.CatalogItems.GetCatalogItemPDP;
using Application.Comments.Command;
using Application.Comments.Dto;
using DNTCaptcha.Core;
using DotNet.RateLimiter.ActionFilters;
using Ganss.XSS;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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
        private readonly ILogger<ProductController> _logger;
        private static readonly NLog.Logger nlog = NLog.LogManager.GetCurrentClassLogger();
        public ProductController(IGetCatalogIItemPLPService
            getCatalogIItemPLPService
            , IGetCatalogItemPDPService getCatalogItemPDPService,
            IAddCommentService _addComment)
        {
            this.getCatalogIItemPLPService = getCatalogIItemPLPService;
            this.getCatalogItemPDPService = getCatalogItemPDPService;
            addComment = _addComment;
        }
        [RateLimit(PeriodInSec = 1, Limit = 2)]
        public IActionResult Index(CatlogPLPRequestDto catlogPLPRequestDto)
        {
            var data = getCatalogIItemPLPService.Execute(catlogPLPRequestDto);
            nlog.Trace("Trace");
            return View(data);
        }
        [RateLimit(PeriodInSec = 1, Limit = 2)]
        [Route("[controller]/[action]/pid-{id}/{slug}")]
        public IActionResult Details(int Id , string slug)
        {
            var data = getCatalogItemPDPService.Execute(Id);
            nlog.Trace("Trace");
            return View(data);
        }
        [RateLimit(PeriodInSec = 30, Limit = 4)]
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
            nlog.Trace("Trace");
            if (result.IsSuccess)
            {
                TempData["Successcomment"] = "پیغام با موفقیت ثبت گردید\n پس از بررسی و در صورت نداشتن محتوای غیر اخلاقی پیغام نمایش داده می شود.";
            }
            else
            {
                TempData["Successcomment"] = result.Message;
            }
            
            var referer = HttpContext.Request.Headers["Referer"].ToString();
            return Redirect(referer);
        }
    }
}
