using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.ViewComponents.Category
{
    public class CategoryListViewComponent:ViewComponent
    {
        ICategoryService _categoryService;

        public CategoryListViewComponent(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public IViewComponentResult Invoke()
        {
            var values = _categoryService.GetList();
            return View(values);
        }
    }
}
