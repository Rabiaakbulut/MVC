using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class StatisticsController : Controller
    {
        // GET: Statistics
        Context _context = new Context();
        public ActionResult Index()
        {
            var totalCategory = _context.Categories.Count(); 
            ViewBag.totalNumberOfCategories = totalCategory;

            var softwareCategory = _context.Headings.Count(x => x.CategoryId == 15); 
            ViewBag.softwareCategoryTitleNumber = softwareCategory;

            var writerNameSortByA = _context.Writers.Count(x => x.WriterName.Contains("a"));
            ViewBag.writerNameSortByA = writerNameSortByA;

            var mostTitles = _context.Headings.Max(x => x.Category.CategoryName); 
            ViewBag.categoryNameWithTheMostTitles = mostTitles;

            var categoryStatusTrue = _context.Categories.Count(x => x.CategoryStatus == true); 
            ViewBag.activeCategories = categoryStatusTrue;

            return View();
        }
    }
}