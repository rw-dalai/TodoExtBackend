namespace Todo2Backend.Model;

public class Category : BaseEntity<int>
{
    
    public string Name { get; set; }
    public string Description { get; set; }
    public Priority Priority { get; set; }
    
    // Navigation Property
    public User Owner { get; set; }
    
    // For use Developer
    public Category(string name, string description, Priority priority)
    {
        Name = name;
        Description = description;
        Priority = priority;
    }
    
    // For use with Entity Framework .NET Core
    protected Category() { }
}