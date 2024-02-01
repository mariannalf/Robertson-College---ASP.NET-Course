using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CandyVendingMachine.Models;

namespace CandyVendingMachine.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var candyList = new List<Candy>
        {
            new Candy { Name = "Snickers", Weight= 50, Price = 1.30, Image = Url.Content("~/img/snickers.png") },
            new Candy { Name = "Kit Kat", Weight= 40, Price = 1.25, Image = Url.Content("~/img/kit-kat.png") },
            new Candy { Name = "Twix", Weight= 82, Price = 2.10, Image = Url.Content("~/img/twix.jpg") },
            new Candy { Name = "M&M's", Weight= 150, Price = 1.0, Image = Url.Content("~/img/mm.jpg" )},
            new Candy { Name = "Reese's", Weight= 150, Price = 1.50, Image = Url.Content("~/img/reeses.png") },
            new Candy { Name = "Almond Joy", Weight= 20, Price = 0.90, Image = Url.Content("~/img/almond-joy.jpg") },
            new Candy { Name = "Milky Way", Weight= 90, Price = 1.10,Image = Url.Content("~/img/milky-way.jpg") }
        };

        return View(candyList);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
