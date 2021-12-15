using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using CoreDemo.Models;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class BlogController : Controller
    {
        IBlogService _blogService;

        public BlogController(IBlogService blogService)
        {
            _blogService = blogService;
        }

        public IActionResult Index()
        {
            var values = _blogService.GetBlogListWithCategory();

            return View(values) ;
        }
        public IActionResult BlogDetails(int id)
        {
            ViewBag.i = id;
            var values = _blogService.GetBlogById(id);
            return View(values);
        }
    }
}
