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
    public IActionResult Contact(Contact form)
    {
        if (!ModelState.IsValid)
        {
            ViewBag.error = "لطفا مجدد تلاش نمایید";
            return View(form);
        }
        ViewBag.success = "پیام شما با موفقیت ارسال شد";
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
    }
}