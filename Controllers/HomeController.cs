using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Sana06.Models;

namespace Sana06.Controllers;

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
    public IActionResult About()
    {
        ViewData["Message"] = "Це сторінка про нас.";
        return View();
    }

    public IActionResult Services()
    {
        ViewData["Message"] = "Наші послуги.";
        return View();
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
