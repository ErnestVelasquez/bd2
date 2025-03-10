using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using bd11.Models;
using bd11.DB;

namespace bd11.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly AppDbContext appDbContext;

    public HomeController(ILogger<HomeController> logger, AppDbContext _dbContext)
    {
        _logger = logger;
        appDbContext = _dbContext;
    }

    public IActionResult Index()
    {
        var alumnos = appDbContext.Alumnos.ToList();
        return View(alumnos);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
