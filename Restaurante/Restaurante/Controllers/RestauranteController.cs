﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Restaurante.Controllers
{
    public class RestauranteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}