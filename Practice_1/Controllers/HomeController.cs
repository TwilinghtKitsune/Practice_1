using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Practice_1.Models;


namespace Practice_1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(ClassForForm form)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("rin", "123321");
            dictionary.Add("samanta", "Key1");
            dictionary.Add("lily", "qweRty");
            string login = null;
            string password = null;

            if (form.Login != null)
            {
                login = form.Login.ToLower();
            }
            if (form.Password != null)
            {
                password = form.Password;
            }

            if (ModelState.IsValid && login != null && password != null)
            {
                if (dictionary.ContainsKey(login))
                {
                    if (dictionary[login] == password) return RedirectToAction("Welcome", "PageTwo");
                }
                ViewBag.Wrong = "Неверный логин или пароль";
                return View();               
            }                
            else
                return View();
        }
    }
}
