﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleBlog2.Controllers
{
    public class PostsController: Controller
    {
        public ActionResult Index()
        {
            return Content("Hello Mehmet");
        }
    }

    
}