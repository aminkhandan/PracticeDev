namespace DevCard.Models;

public class Article
{
    public int id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Image { get; set; }

    public Article(int id, string title, string description, string image)
    {
        this.id = id;
        Title = title;
        Description = description;
        Image = image;
    }
}