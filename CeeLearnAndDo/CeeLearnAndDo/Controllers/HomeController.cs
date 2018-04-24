using CeeLearnAndDo.Models;
using CeeLearnAndDo.Models.MyModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace CeeLearnAndDo.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            var Articles = db.Articles.Where(a => a.Published == true).Take(3);

            return View(Articles);
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

            var articles = db.Articles.Where(a => a.Published == true).ToList();

            return View(articles);
        }

        public ActionResult Questions()
        {
            ViewBag.Message = "Questions page";

            var questions = db.Questions.Where(q => q.Published == true).ToList();

            return View(questions);
        }

        public ActionResult AskQuestion()
        {
            ViewBag.Message = "Ask a question";

            return View();
        }

        public ActionResult Article(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Article article = db.Articles.Find(id);
            if (article == null)
            {
                return HttpNotFound();
            }

            return View(article);
        }
    }
}