using Application.Comments.Query;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSite.EndPoint.Models.ViewComponents.Comment
{
    public class GetComment : ViewComponent
    {
        private readonly IGetCommentForView _getComment;

        public GetComment(IGetCommentForView getComment)
        {
            _getComment = getComment;
        }

        public async Task<IViewComponentResult> InvokeAsync(int postId)
        {

            var result = _getComment.Exequte(postId);
           
            var viewName = $"~/Views/Shared/Components/Comment/{this.ViewComponentContext.ViewComponentDescriptor.ShortName}.cshtml";
            return View(viewName, result.Data);
        }
    }
}
