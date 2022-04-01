using DevCard.Models;

namespace DevCard.Data;

public class ProjectStore
{
    public static List<Project> GetProject()
    {
        return new List<Project>
        {
            new Project(1, "project 1", "Test", "project-1.jpg", "amin"),
            new Project(2, "project 2", "Test2", "project-2.jpg", "reza"),
            new Project(3, "project 3", "Test3", "project-3.jpg", "mamad"),
            new Project(4, "project 4", "Test4", "project-4.jpg", "hamid"),
        };
    }

    public static Project GetProjectBy(int id)
    {
        return GetProject().FirstOrDefault(p => p.id == id);
    }
}