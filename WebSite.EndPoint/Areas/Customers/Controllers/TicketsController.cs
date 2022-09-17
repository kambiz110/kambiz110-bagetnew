using Application.Tickets.Command;
using Application.Tickets.Dto;
using Application.Tickets.Query;
using DNTCaptcha.Core;
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

        public TicketsController(IAddTicketService addTicket,
            ICustomerGetTickets customerGetTickets)
        {
            this.addTicket = addTicket;
            this.customerGetTickets = customerGetTickets;
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
        public IActionResult AddTicket(AddTicketDto dto)
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
            addTicket.Add(dto);
            return View(nameof(Index));
        }
    }
}
