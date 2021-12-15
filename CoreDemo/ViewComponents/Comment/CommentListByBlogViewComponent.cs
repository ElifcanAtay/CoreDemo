using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.ViewComponents.Comment
{
    public class CommentListByBlogViewComponent : ViewComponent
    {
        ICommentService _commentService;

        public CommentListByBlogViewComponent(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public IViewComponentResult Invoke(int id)
        {
            var values = _commentService.GetList(id);
            return View(values);
        }
    }
}
