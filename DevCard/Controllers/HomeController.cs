using System.Diagnostics;
using DevCard.Data;
using DevCard.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DevCard.Controllers;

public class HomeController : Controller
    {
        private readonly List<Service> _services = new List<Service>
        {
            new Service(1, "طلایی"),
            new Service(2, "نقره ای"),
            new Service(3, "خاکستری"),
            new Service(4, "برنز")
        };

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact(string name)
        {
            var form = new Contact
            {
                Services = new SelectList(_services, "Id", "Name")
            };
            return View(form);
        }

        public IActionResult ProjectDetails(int id)
        {
            var project = ProjectStore.GetProjectBy(id);
            return View(project);
        }

        [HttpPost]
        public IActionResult Contact(Contact form)
        {
            form.Services = new SelectList(_services, "Id", "Name");
            if (!ModelState.IsValid)
            {
                ViewBag.error = "لطفا مجدد تلاش نمایید";
                return View(form);
            }

            ModelState.Clear();
            form = new Contact
            {
                Services = new SelectList(_services, "Id", "Name")
            };
            ViewBag.success = "پیام شما با موفقیت ارسال شد";
            return View(form);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }