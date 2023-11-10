using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KayseriUlasimApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace KayseriUlasim.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}