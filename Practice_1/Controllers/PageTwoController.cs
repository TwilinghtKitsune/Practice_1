using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Practice_1.Models;

namespace Practice_1.Controllers
{
    public class PageTwoController : Controller
    {
        // GET: PageTwo
        public ActionResult Welcome()
        {
            return View();
        }
        

        [HttpPost]
        public ActionResult Welcome(PageTwo model, string[] pets)
        {
            ViewBag.Label = "Вы выбрали/ввели: " + model.TextBox + " ";
            if (pets != null)
            {
                foreach (string c in pets)
                {
                    ViewBag.Label += c;
                    ViewBag.Label += " ";
                }
            }
            ViewBag.Label += Request.Form["Пол"];
            ViewBag.Label += " ";
            ViewBag.Label += model.Seasons;

            return View(model);
        }
    }
}