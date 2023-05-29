using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Heloflix.Models;
using 


namespace Heloflix.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        List<Genre> genres = new()
        {
            new Genre()
            {
                Id = 1,
                nameof = "Ação"
            },
            {
                new Genre()
                Id = 2,
                nameof = "Terror"
            }
        };
        genres.Add(
            new()
            {
                Id = 3,
                nameof = "Drama"
            }
        );
        return View(genres);
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
