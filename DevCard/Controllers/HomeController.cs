using System.Diagnostics;
using DevCard.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Contact()
    {
        return View();
    }

    [HttpPost]
    public JsonResult Contact(Contact form)
    {
        Console.WriteLine(form.ToString());
        return Json(Ok());
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
    }
}