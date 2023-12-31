﻿using Microsoft.AspNetCore.Mvc;
using Proyeto.Models;
using System.Diagnostics;

namespace Proyeto.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

       
        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Entrada()
        {
            return View();
        }

        public IActionResult HistorialAcademico()
        {
            return View();
        }
        public IActionResult ProductoAcademico()
        {
            return View();
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}