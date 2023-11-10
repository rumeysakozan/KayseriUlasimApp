using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using KayseriUlasimApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace KayseriUlasim.Controllers
{
    public class CardController : Controller
    {
        public IActionResult Cards()
        {
            return View("Cards", Repository.KayseriUlasimAppCards);
        }
        public IActionResult Content(int? id)
        {
            var kart = Repository.GetById(id);
            return View(kart);
        }
    }
}