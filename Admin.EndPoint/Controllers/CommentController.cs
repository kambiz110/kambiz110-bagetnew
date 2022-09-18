using Admin.EndPoint.Helper;
using Application.Comments.Command;
using Application.Comments.Dto;
using Application.Comments.Query;
using Application.Dtos;
using Application.Interfaces.Contexts;
using Domain.Comments;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
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
        private readonly IDataBaseContext _context;
        private readonly IGetCommentForAdmin _getComment;
        private readonly IEditStatusCommentService _editStatusCommentService;
        private readonly IAnswerCommentAdmin _answerComment;
        public CommentController(IGetCommentForAdmin getComment, IEditStatusCommentService editStatusCommentService, IAnswerCommentAdmin answerComment, IDataBaseContext context)
        {
            _getComment = getComment;
            _editStatusCommentService = editStatusCommentService;
            _answerComment = answerComment;
            _context = context;
        }
        [HttpGet, HttpPost]
        public IActionResult Index(int pageSize = 10, int pageNo = 1, string q = "", byte confirmPublish = 0, string search = "", string confirmPublishClick = "")
        {
            if (search == "clear")
            {
                HttpContext.Session.SetString("isConfirmComment", "");

                return RedirectToAction("Index");
            }
            bool confirm = false;
            bool ConfirmPost = confirmPublish == 1 ? true : false;
            if (HttpContext.Session.GetString("isConfirmComment") != null && HttpContext.Session.GetString("isConfirmComment") != "")
            {
                confirm = HttpContext.Session.GetString("isConfirmComment") == "1" ? true : false;
                if (confirmPublishClick != "")
                {
                    var strIsConfirmPost = confirmPublish == 1 ? "1" : "0";
                    HttpContext.Session.SetString("isConfirmComment", strIsConfirmPost);
                    confirm = ConfirmPost;
                }
            }
            if (HttpContext.Session.GetString("isConfirmComment") == null || HttpContext.Session.GetString("isConfirmComment") == "")
            {
                if (confirmPublish == 1)
                {
                    HttpContext.Session.SetString("isConfirmComment", "1");
                    confirm = true;
                }
                else
                {
                    HttpContext.Session.SetString("isConfirmComment", "0");
                    confirm = false;
                }
            }
            ViewData["Title"] = "نظرات";
            // (int PageSize, int PageNo, string searchKey, string userName, bool confirm)
            var result = _getComment.Exequte(pageSize, pageNo, q, User.Identity.Name, confirm);
            return View(result.Data);
        }


        public IActionResult Trashed(long[] ids)
        {
            string ip = HttpContext.Request.HttpContext.Connection.RemoteIpAddress.ToString();
            var userid = User.Identity.Name;
            var result = _editStatusCommentService.Exequte(ids, 3, userid, ip);
            TempData["Message"] = result.Message;
            TempData["alertClass"] = result.IsSuccess ? "success" : "danger";
            return RedirectToAction("Index");
        }

        public IActionResult Publish(long[] ids)
        {
            string ip = HttpContext.Request.HttpContext.Connection.RemoteIpAddress.ToString();
            var userid = User.Identity.Name;
            var result = _editStatusCommentService.Exequte(ids, 1, userid, ip);
            TempData["Message"] = result.Message;
            TempData["alertClass"] = result.IsSuccess ? "success" : "danger";
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Answer(long[] ids)
        {
            string ip = HttpContext.Request.HttpContext.Connection.RemoteIpAddress.ToString();
            var userid = User.Identity.Name;
            var result = _editStatusCommentService.Exequte(ids, 1, userid, ip);
            TempData["Message"] = result.Message;
            TempData["alertClass"] = result.IsSuccess ? "success" : "danger";
            return RedirectToAction("Index");
        }


        public IActionResult Answer(AjaxAnswerCommentDto data)
        {
            bool confirm = false;

            if (HttpContext.Session.GetString("isConfirmComment") != null && HttpContext.Session.GetString("isConfirmComment") != "")
            {
                confirm = HttpContext.Session.GetString("isConfirmComment") == "1" ? true : false;

            }
            string ip = "";
            if (HttpContext.Connection.RemoteIpAddress != null)
            {
                ip = HttpContext.Connection.RemoteIpAddress.ToString();
                data.IP = ip;
            }
            string userName = "";
            if (User.Identity.IsAuthenticated)
            {
                userName = User.Identity.Name;
            }
            var result = _answerComment.Exequte(data, userName, ip);
            if (result.IsSuccess)
            {
                var comments = _getComment.Exequte(10, 1, "", User.Identity.Name, confirm);
                var viewHtml = this.RenderViewAsync("_PartialTbl_Comment", comments.Data, true);
                return Json(new ResultDto<string>
                {
                    Data = viewHtml,
                    IsSuccess = true,
                    Message = "عملیات افزودن پاسخ موفق بود."
                }); ;
            }
            return Json(new ResultDto
            {
                IsSuccess = false,
                Message = "ناموفق."
            });
        }
       
        public IActionResult Edit(EditCommentMessageDto data)
        {
            data.userName = User.Identity.Name;
            var result = _editStatusCommentService.EditComment(data);
            TempData["alertClass"] = result.IsSuccess ? "success" : "danger";
            TempData["Message"] = result.Message;
            if (result.Data != null)
            {
                return Json(new ResultDto<string>
                {
                    Data = result.Data,
                    IsSuccess = true,
                    Message = "عملیات ویرایش موفق بود."
                });
            }
            return Json(new ResultDto<Comment>
            {
                Data = null,
                IsSuccess = false,
                Message = "ناموفق."
            });
        }
        //[Route("Comment/Edit/{id}")]
        public IActionResult FindComment(long id)
        {
            var comment = _context.Comments.Where(p => p.Id == id).FirstOrDefault();
            if (comment != null)
            {
                return Json(new ResultDto<Comment>
                {
                    Data = comment,
                    IsSuccess = true,
                    Message = "عملیات ویرایش موفق بود."
                });
            }
            return Json(new ResultDto<Comment>
            {
                Data = null,
                IsSuccess = false,
                Message = "ناموفق."
            });
        }
    }
}
