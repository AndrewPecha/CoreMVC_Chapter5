﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Razor.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Razor.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public ViewResult Index()
        {
            Product myProduct = new Product
            {
                ProductID = 1,
                Name = "Kayak",
                Description = "A boat for one person",
                Category = "Watersports",
                Price = 275m
            };

            ViewBag.StockLevel = 2;

            return View(myProduct);
        }
    }
}
