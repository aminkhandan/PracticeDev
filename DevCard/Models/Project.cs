namespace DevCard.Models;

public class Project
{
    public int id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Client { get; set; }
    public string Image { get; set; }

    public Project(int id, string name, string description,string image, string client)
    {
        this.id = id;
        Name = name;
        Description = description;
        Client = client;
        Image = image;
    }
}