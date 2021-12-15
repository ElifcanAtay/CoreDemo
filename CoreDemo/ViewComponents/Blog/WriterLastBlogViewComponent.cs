using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.ViewComponents.Blog
{
    public class WriterLastBlogViewComponent:ViewComponent
    {
        IBlogService _blogService;

        public WriterLastBlogViewComponent(IBlogService blogService)
        {
            _blogService = blogService;
        }
        public IViewComponentResult Invoke()
        {
            var values = _blogService.GetBlogListByWriter(1);
            return View(values);
        }
    }
}
