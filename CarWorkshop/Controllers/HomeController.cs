using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CarWorkshop.Models;

namespace CarWorkshop.Controllers;

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

    public IActionResult About() {
        var model = new List<Person>()
       {
            new Person()
            {
                FirstName = "Adrian",
                LastName = "Urzędncizek"
            },
            new Person()
            {
                FirstName = "Antek",
                LastName = "Urzędncizek"
            },
        };
        return View(model);
    }
    public IActionResult Privacy()
    {
        var model = new List<Person>()
        {
            new Person() 
            {
                FirstName = "Adrian",
                LastName = "Urzędncizek"
            },
            new Person() 
            {
                FirstName = "Antek",
                LastName = "Urzędncizek"
            },
        };
        return View(model);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
