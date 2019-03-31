using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WcfModel;
using WcfCommon;

namespace BookMgr.Client.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult WcfApi()
        {
            BookServiceRef.BookServiceClient book = new BookServiceRef.BookServiceClient();
            Books books = XmlHelper.DeSerializer<Books>(book.GetBook("4939"));
            ViewData["books"] = books;
            return View();
        }

    }
}
