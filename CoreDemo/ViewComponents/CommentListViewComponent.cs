using CoreDemo.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.ViewComponents
{
    public class CommentListViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentValues = new List<UserCommentViewModel>
            {
                new UserCommentViewModel
                {
                    Id=1,
                    UserName ="Elifcan"
                },
                new UserCommentViewModel
                {
                    Id=2,
                    UserName ="Burak"
                },
                new UserCommentViewModel
                {
                    Id=3,
                    UserName ="Neşet"
                },
            };
            return View(commentValues);
        }
    }
}
