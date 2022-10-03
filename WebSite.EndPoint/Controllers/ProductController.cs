using Application.Catalogs.CatalogItems.GetCatalogIItemPLP;
using Application.Catalogs.CatalogItems.GetCatalogItemPDP;
using Application.Comments.Command;
using Application.Comments.Dto;
using AspNetCore.SEOHelper.Sitemap;
using DNTCaptcha.Core;
using DotNet.RateLimiter.ActionFilters;
using Ganss.XSS;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
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
        private readonly IWebHostEnvironment _env;
        public ProductController(IGetCatalogIItemPLPService
            getCatalogIItemPLPService
            , IGetCatalogItemPDPService getCatalogItemPDPService,
            IAddCommentService _addComment, IWebHostEnvironment env)
        {
            this.getCatalogIItemPLPService = getCatalogIItemPLPService;
            this.getCatalogItemPDPService = getCatalogItemPDPService;
            addComment = _addComment;
            _env = env;
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
        public IActionResult Details(int Id, string slug)
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



        [ResponseCache(Duration = 1200)]
        [HttpGet("/rss.xml")]
        public IActionResult Rss()
        {
            var feed = new SyndicationFeed("Title", "Description", new Uri("https://hamedfathi.me"), "RSSUrl", DateTime.Now);
            feed.Copyright = new TextSyndicationContent($"{DateTime.Now.Year} yadakcarshop.com");
            var items = new List<SyndicationItem>();
            var postings = getCatalogIItemPLPService.RssCatalog();
            var datee = DateTime.Now;
            foreach (var item in postings)
            {
                var postUrl = Url.Action("Details", "Product", new { id = item.Id, slug = item.Slug }, HttpContext.Request.Scheme);
                var title = item.Name;
                var description = item.Description.ToString();
                items.Add(new SyndicationItem(title, description, new Uri(postUrl), item.Slug, datee));
            }
            feed.Items = items;
            var settings = new XmlWriterSettings
            {
                Encoding = Encoding.UTF8,
                NewLineHandling = NewLineHandling.Entitize,
                NewLineOnAttributes = true,
                Indent = true
            };
            using (var stream = new MemoryStream())
            {
                using (var xmlWriter = XmlWriter.Create(stream, settings))
                {
                    var rssFormatter = new Rss20FeedFormatter(feed, false);
                    rssFormatter.WriteTo(xmlWriter);
                    xmlWriter.Flush();
                }
                return File(stream.ToArray(), "application/rss+xml; charset=utf-8");
            }
        }
        [ResponseCache(Duration = 1200)]
        [HttpGet("/sitemap")]
        public string SiteMap()
        {
            var list = new List<SitemapNode>();


            var postings = getCatalogIItemPLPService.RssCatalog();
            var datee = DateTime.Now; 
           
            foreach (var item in postings)
            {
                var postUrl = new Uri(Url.Action("Details", "Product", new { id = item.Id, slug = item.Slug }, HttpContext.Request.Scheme));

                var title = item.Name;
                var description = item.Description.ToString();
                list.Add(new SitemapNode { LastModified = DateTime.UtcNow, Priority = 0.8, Url = postUrl.ToString(), Frequency = SitemapFrequency.Monthly });
               // items.Add(new SyndicationItem(title, description, new Uri(postUrl), item.Slug, datee));
            }
             new SitemapDocument().CreateSitemapXML(list, _env.ContentRootPath);
            return "sitemap.xml file should be create in root directory";
        }
    }
}
