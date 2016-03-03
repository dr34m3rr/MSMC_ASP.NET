using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mySite.Controllers
{
    public class AboutController : Controller
    {
        //
        // GET: /About/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult More()
        {
            return View();
        }

        public ActionResult Books()
        {
            var books = mySite.Models.BooksFactory.CreateBooks();
            return View(books);
        }

    }
}
