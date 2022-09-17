using Application.Comments.Command;
using Application.Comments.Dto;
using Application.Comments.Query;
using Application.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.EndPoint.Controllers
{
    [Authorize(Roles = "Administrator,Maneger")]
    public class CommentController : Controller
    {
        private readonly IGetCommentForAdmin _getComment;
        private readonly IEditStatusCommentService _editStatusCommentService;
        private readonly IAnswerCommentAdmin _answerComment;
        public CommentController(IGetCommentForAdmin getComment, IEditStatusCommentService editStatusCommentService, IAnswerCommentAdmin answerComment)
        {
            _getComment = getComment;
            _editStatusCommentService = editStatusCommentService;
            _answerComment = answerComment;
        }
        [HttpGet, HttpPost]
        public IActionResult Index(int PageSize = 10, int PageNo = 1, string q = "")
        {
            if (q.Trim() != "")
            {
                var res = _getComment.Exequte(PageSize, PageNo, q);
                return View(res.Data);
            }
            var result = _getComment.Exequte(PageSize, PageNo, User.Identity.Name);
            return View(result.Data);
        }

        public IActionResult Trashed(long[] ids)
        {
            var userid = User.Identity.Name;
            var result = _editStatusCommentService.Exequte(ids, 3, userid);
            TempData["Message"] = result.Message;
            TempData["alertClass"] = result.IsSuccess ? "success" : "danger";
            return RedirectToAction("Index");
        }

        public IActionResult Publish(long[] ids)
        {
            var userid = User.Identity.Name;
            var result = _editStatusCommentService.Exequte(ids, 1, userid);
            TempData["Message"] = result.Message;
            TempData["alertClass"] = result.IsSuccess ? "success" : "danger";
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Answer(long[] ids)
        {
            var userid = User.Identity.Name;
            var result = _editStatusCommentService.Exequte(ids, 1, userid);
            TempData["Message"] = result.Message;
            TempData["alertClass"] = result.IsSuccess ? "success" : "danger";
            return RedirectToAction("Index");
        }


        public IActionResult Answer(AjaxAnswerCommentDto data)
        {
            string ip = "";
            if (HttpContext.Connection.RemoteIpAddress != null)
            {
                ip = HttpContext.Connection.RemoteIpAddress.ToString();

            }
            string userName = "";
            if (User.Identity.IsAuthenticated)
            {
                userName = User.Identity.Name;
            }
            var result = _answerComment.Exequte(data, userName, ip);
            if (result.IsSuccess)
            {
                return Json(new ResultDto
                {
                    IsSuccess = true,
                    Message = "عملیات درج پاسخ موفق بود."
                });
            }
            return Json(new ResultDto
            {
                IsSuccess = false,
                Message = "ناموفق."
            });
        }
    }
}
