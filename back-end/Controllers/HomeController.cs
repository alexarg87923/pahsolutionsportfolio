namespace pahsolutionsportfolio.Controllers;

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using pahsolutionsportfolio.Models;

public class HomeController(ILogger<HomeController> logger) : Controller
{
    private readonly ILogger<HomeController> _logger = logger;

    [HttpGet]
    public IActionResult Index()
    {
        _logger.LogDebug("Entering '/' GET route...");
        return View();
    }

    [HttpGet]
    public IActionResult Privacy()
    {
        _logger.LogDebug("Entering '/privacy' GET route...");
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        _logger.LogDebug("Entering '/error' GET route...");
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
