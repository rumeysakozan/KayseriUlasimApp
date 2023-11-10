using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using KayseriUlasimApp.Models;

namespace KayseriUlasimApp.Controllers;

public class HomeController : Controller
{

    public IActionResult Index()
    {
        return View(Repository.KayseriUlasimAppCards);
    }
    public IActionResult About()
    {
        return View(Repository.KayseriUlasimAppCards);
    }
}
