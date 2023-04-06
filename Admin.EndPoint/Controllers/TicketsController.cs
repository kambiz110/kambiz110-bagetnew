using Admin.EndPoint.Helper;
using Application.Logs.Command;
using Application.Tickets.Command;
using Application.Tickets.Dto;
using Application.Tickets.Query;
using Infrastructure.SMS;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.EndPoint.Controllers
{
    [Authorize(Roles = "Administrator,Maneger")]
    public class TicketsController : Controller
    {
        private readonly IAdminGetTickets adminGetTickets;
        private readonly IGetAnswerDitels getAnswer;
        private readonly IAddAnswerInTicket _addAnswer;
        private readonly IAddUserLog _userLog;
        private readonly ISmsServices smsServices;
        public TicketsController(IAdminGetTickets adminGetTickets
            , IGetAnswerDitels getAnswer, IAddAnswerInTicket addAnswer, IAddUserLog userLog, ISmsServices smsServices)
        {
            this.adminGetTickets = adminGetTickets;
            this.getAnswer = getAnswer;
            this._addAnswer = addAnswer;
            _userLog = userLog;
            this.smsServices = smsServices;
        }
        public IActionResult Index(int PageSize = 10, int PageNo = 1, string q = "", string search = "" , bool stat =false)
        {
            if (search == "clear")
            {
                return RedirectToAction("Index");
            }
            var model = adminGetTickets.GetTickets(PageSize ,  PageNo,  q , stat);
            return View(model);
        }
        public IActionResult Respons(int id) 
        {
            ViewBag.AnsweruserId = ClaimUtility.GetUserId(User);
            var model = getAnswer.AnswerDitels(id);
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Respons(AddAnswerDto dto) 
        {
            if (!ModelState.IsValid)
            {
                ViewBag.userId = ClaimUtility.GetUserId(User);
                return View(dto);
            }
          await _addAnswer.addAnswer(dto);
            _userLog.adduserlog(new Application.Logs.Dto.AddUserLogDto { userName = User.Identity.Name, userEvent = Domain.Logs.logEvent.answerTicket, StrKeyTable = dto.Id.ToString(), Ip = HttpContext.Connection.RemoteIpAddress?.ToString() });
            await smsServices.TicketStatAsync(User.Claims.FirstOrDefault(c => c.Type == "FullName")?.Value, "   کارشناس پشتیبان پاسخ داده شده ", dto.PhoneNumber);

            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id) 
        {
            ViewBag.AnsweruserId = ClaimUtility.GetUserId(User);
            var model = getAnswer.AnswerDitels(id);
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(AddAnswerDto dto) 
        {
            if (!ModelState.IsValid)
            {
                ViewBag.userId = ClaimUtility.GetUserId(User);
                return View(dto);
            }
          await  _addAnswer.addAnswer(dto);
            _userLog.adduserlog(new Application.Logs.Dto.AddUserLogDto { userName = User.Identity.Name, userEvent = Domain.Logs.logEvent.editTicket, StrKeyTable = dto.Id.ToString(), Ip = HttpContext.Connection.RemoteIpAddress?.ToString() });

            return View(nameof(Index));
        }
    }
}
