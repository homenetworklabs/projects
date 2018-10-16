using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DNS_GUI.Models;

namespace DNS_GUI.Controllers
{
    public class RequestsController : Controller
    {
        // GET: Requests
        public ActionResult Index()
        {
            var request = new Request() { Name = "Request1"};
            return View(request);
        }
    }
}