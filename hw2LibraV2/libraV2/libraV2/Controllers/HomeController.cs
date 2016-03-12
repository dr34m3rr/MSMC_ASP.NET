using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using libraV2.Models;

namespace libraV2.Controllers
{
    public class HomeController : Controller
    {
        libraContext db = new libraContext();
        // GET: Home
        public ActionResult Index()
        {
            IEnumerable<book> books = db.Books;
            IEnumerable<user> users = db.Users;
            ViewBag.Books = books;
            ViewBag.Users = users;
            return View();
        }
    }
}