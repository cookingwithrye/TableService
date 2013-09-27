using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TableService.Controllers
{
    public class WaiterController : Controller
    {
        //
        // GET: /Waiter/

        public ActionResult Index()
        {
            //send back sample page and explanation
            return View();
        }

        //
        // POST: /Waiter/TableForOne/"<html>...</html>"

        //[HttpPost]
        public ActionResult TableForOne(string html)
        {
            //TODO: parse the html, convert to tables, then return it
            
            ViewBag.TableHtml = html;
            return View();
        }
    }
}
