using DevCard.Data;
using DevCard.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace DevCard.ViewComponents;

public class ProjectsViewComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        var projects = ProjectStore.GetProject();
        return View("_Projects",projects);
    }
}