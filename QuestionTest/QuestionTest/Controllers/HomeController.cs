using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QuestionTest.Models;

namespace QuestionTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public bool GetData(Answer answer)
        { 
            using (AnswerContext db = new AnswerContext())
            {
                db.Answers.Add(answer);
                db.SaveChanges();
            }
            return true;
        }

       
        
    }
}