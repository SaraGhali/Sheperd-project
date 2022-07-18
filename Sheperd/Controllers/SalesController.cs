using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Sheperd.Models;

namespace Sheperd.Controllers
{
    public class SalesController : Controller
    {
        private SheperdEntities db = new SheperdEntities();

        public ActionResult CreateFatora()
        {
            return View();
        }
    }
}
