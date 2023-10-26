using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DojoSurvey.Models;

namespace DojoSurvey.Controllers;

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


    [HttpPost("ProcesarDatos")]
    public IActionResult ProcesarDatos(string txtName, string locationDojo, string favoriteLanguage, string txareaComment)
    {
        Console.WriteLine($"{txtName} {locationDojo} {favoriteLanguage} {txareaComment}");
        ViewBag.textname = txtName;
        ViewBag.locadojo = locationDojo;
        ViewBag.favolang = favoriteLanguage;
        ViewBag.txtarea = txareaComment;
        return View("SubmittedForm");
    }



    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
