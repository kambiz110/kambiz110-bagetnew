using Application.HomePageService;
using DotNet.RateLimiter.ActionFilters;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebSite.EndPoint.Models;
using WebSite.EndPoint.Utilities.Filters;

namespace WebSite.EndPoint.Controllers
{

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private static readonly NLog.Logger nlog = NLog.LogManager.GetCurrentClassLogger();
        private readonly IHomePageService homePageService;

        public HomeController(ILogger<HomeController> logger
            , IHomePageService homePageService)
        {
            _logger = logger;
            this.homePageService = homePageService;
        }
        [RateLimit(PeriodInSec = 5, Limit = 5)]
        [ServiceFilter(typeof(SaveVisitorFilter))]
        public IActionResult Index()
        {
            //var data = homePageService.GetData();
            //return View(data);
            nlog.Trace("Trace");
            return View();
        }


        public IActionResult about()
        {
            return View();
        }
        [Route("Home/Display")]
        public IActionResult Display()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            nlog.Trace("Trace");
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
