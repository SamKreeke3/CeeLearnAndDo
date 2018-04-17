using CeeLearnAndDo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CeeLearnAndDo.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Articles()
        {
            ViewBag.Message = "Articles page";

            var Articles = db.Articles.Where(a => a.Published == true).ToList();

            return View(Articles);
        }

        public ActionResult Questions()
        {
            ViewBag.Message = "Questions page";

            var questions = db.Questions.ToList();

            return View(questions);
        }
    }
}