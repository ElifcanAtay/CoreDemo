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
    public class NewsLetterController : Controller
    {
        INewsLetterService _newsLetterService;

        public NewsLetterController(INewsLetterService newsLetterService)
        {
            _newsLetterService = newsLetterService;
        }

        [HttpGet]
        public ActionResult SubscribeMail()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SubscribeMail(NewsLetter p)
        {
           
            p.MailStatus = true;
            _newsLetterService.NewsLetterAdd(p);
            return RedirectToAction("Index","Blog");
        }
      
    }
}
