using DevCard.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard.ViewComponents;

public class LatestArticleViewComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        var articles = new List<Article>
        {
           new Article(1,"test","test","blog-post-thumb-1.jpg"),
           new Article(2,"test","test","blog-post-thumb-2.jpg"),
           new Article(3,"test","test","blog-post-thumb-3.jpg"),
           new Article(4,"test","test","blog-post-thumb-4.jpg"),
        } ;
        return View("_LatestArticle",articles);
    }

}