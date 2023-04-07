using Application.Tickets.Command;
using Application.Tickets.Dto;
using Application.Tickets.Query;
using DNTCaptcha.Core;
using Infrastructure.SMS;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSite.EndPoint.Utilities;

namespace WebSite.EndPoint.Areas.Customers.Controllers
{
    [Authorize]
    [Area("Customers")]
    public class TicketsController : Controller
    {
        private readonly IAddTicketService addTicket;
        private readonly ICustomerGetTickets customerGetTickets;
        private readonly IGetAnswerDitels getAnswer;
        private readonly ISmsServices smsServices;
        public TicketsController(IAddTicketService addTicket,
            ICustomerGetTickets customerGetTickets, ISmsServices smsServices)
        {
            this.addTicket = addTicket;
            this.customerGetTickets = customerGetTickets;
            this.smsServices = smsServices;
        }
        public IActionResult Index(int pageIndex=1, int pageSize=10)
        {
          var  userId = ClaimUtility.GetUserId(User);
            var model = customerGetTickets.GetTickets(userId , pageIndex, pageSize);
            return View(model);
        }
        [HttpGet]
        public IActionResult AddTicket()
        {
            ViewBag.userId = ClaimUtility.GetUserId(User);
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateDNTCaptcha(
        ErrorMessage = "عبارت امنیتی را به درستی وارد نمائید",
        CaptchaGeneratorLanguage = Language.Persian,
        CaptchaGeneratorDisplayMode = DisplayMode.NumberToWord)]
        public async Task<IActionResult> AddTicket(AddTicketDto dto)
        {
            ModelState.Remove("Ip");
            if (!ModelState.IsValid)
            {
                ViewBag.userId = ClaimUtility.GetUserId(User);
                var query = from state in ModelState.Values
                            from error in state.Errors
                            select error.ErrorMessage;
              
                ViewBag.Errors = query.ToList();
                return View(dto);
            }
            var ip = Request.HttpContext.Connection.RemoteIpAddress.ToString();
            dto.Ip = ip;
           var result= addTicket.Add(dto);
            await smsServices.TicketStatAsync(User.Claims.FirstOrDefault(c => c.Type == "FullName")?.Value,  " در انتظار بررسی کارشناس پشتیبان ", dto.PhoneNumber);
            await smsServices.newTicketAsync(User.Claims.FirstOrDefault(c => c.Type == "FullName")?.Value, result.ToString(), "تیکت جدید ", "09108496094");
            await smsServices.newTicketAsync(User.Claims.FirstOrDefault(c => c.Type == "FullName")?.Value, result.ToString(), " تیکت جدید ", "09124918349");
            await smsServices.newTicketAsync(User.Claims.FirstOrDefault(c => c.Type == "FullName")?.Value, result.ToString(), " تیکت جدید ", "09102595008");
            return RedirectToAction("Index");
        }
    }
}
