﻿using SultansKitchen.Web.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SultansKitchen.Web.Controllers
{
    [UserAuthorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Dashboard";

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
   
    }
}