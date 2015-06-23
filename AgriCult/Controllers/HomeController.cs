﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AgriCult.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Response.Cache.SetCacheability(
                System.Web.HttpCacheability.NoCache);
            return View();
        }

        public ActionResult Manifest()
        {
            Response.ContentType = "text/cache-manifest";
            Response.ContentEncoding = System.Text.Encoding.UTF8;
            Response.Cache.SetCacheability(
                System.Web.HttpCacheability.NoCache);
            return View();
        }
    }
}