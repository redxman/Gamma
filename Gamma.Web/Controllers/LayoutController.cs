﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gamma.Web.Controllers
{
    public class LayoutController : GammaControllerBase
    {
        // GET: Layout
        public ActionResult Index()
        {
            return View();
        }
    }
}