﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DIPLOMA.Controllers
{
    public class DirectorysNames : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
