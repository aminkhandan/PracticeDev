using DevCard.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace DevCard.ViewComponents;

public class ProjectsViewComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        var projects = new List<Project>
        {
            new Project(1,"project 1","Test","project-1.jpg","amin"),
            new Project(2,"project 2","Test2","project-2.jpg","reza"),
            new Project(3,"project 3","Test3","project-3.jpg","mamad"),
            new Project(4,"project 4","Test4","project-4.jpg","hamid"),
        };
        return View("_Projects",projects);
    }
}