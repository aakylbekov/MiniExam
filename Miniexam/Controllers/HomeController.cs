using Miniexam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Miniexam.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult HomePage()
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
        public ActionResult Company()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Company(CompanyName input)
        {
            if (ModelState.IsValid)
            {

                return View("Index");
            }
            else
            {
                return View(input);
            }
            //return View();
        }

    }
}