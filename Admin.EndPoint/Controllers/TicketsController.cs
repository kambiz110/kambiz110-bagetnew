using Admin.EndPoint.Helper;
using Application.Tickets.Command;
using Application.Tickets.Dto;
using Application.Tickets.Query;
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
        private readonly IAddAnswerInTicket addAnswer;

        public TicketsController(IAdminGetTickets adminGetTickets
            , IGetAnswerDitels getAnswer, IAddAnswerInTicket addAnswer)
        {
            this.adminGetTickets = adminGetTickets;
            this.getAnswer = getAnswer;
            this.addAnswer = addAnswer;
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
        public IActionResult Respons(AddAnswerDto dto) 
        {
            if (!ModelState.IsValid)
            {
                ViewBag.userId = ClaimUtility.GetUserId(User);
                return View(dto);
            }
            addAnswer.addAnswer(dto);
            return View(nameof(Index));
        }
        public IActionResult Edit(int id) 
        {
            ViewBag.AnsweruserId = ClaimUtility.GetUserId(User);
            var model = getAnswer.AnswerDitels(id);
            return View(model);
        }
        [HttpPost]
        public IActionResult Edit(AddAnswerDto dto) 
        {
            if (!ModelState.IsValid)
            {
                ViewBag.userId = ClaimUtility.GetUserId(User);
                return View(dto);
            }
            addAnswer.addAnswer(dto);
            return View(nameof(Index));
        }
    }
}
