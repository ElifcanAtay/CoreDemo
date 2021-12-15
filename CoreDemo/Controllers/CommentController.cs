using BusinessLayer.Abstract;
using DataAccessLayer;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class CommentController : Controller
    {
        ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult PartialAddComment()
        {
            return View();
        }
        [HttpPost]
        public IActionResult PartialAddComment(Comment p)
        {
            Context c = new Context();
            p.CommentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.CommentStatus = true;
            p.BlogId = c.Blogs.Select(x => x.BlogId).FirstOrDefault();
            _commentService.CommentAdd(p);
            return RedirectToAction("BlogDetails", "Blog", new { id = c.Blogs.Select(x => x.BlogId).FirstOrDefault() });
        }

        public PartialViewResult PartialListByBlog(int id)
        {
            var values = _commentService.GetList(id);
            return PartialView(values);
        }
    }
}
