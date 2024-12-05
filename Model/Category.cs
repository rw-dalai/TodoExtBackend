namespace Todo2Backend.Model;

public class Category : BaseEntity<int>
{
    //😍
    // EF Core Navigation Property
    public User Owner { get; set; }
    
    public string Name { get; set; }
    public string Description { get; set; }
    
    // For use Developer
    public Category(string name, string description)
    {
        Name = name;
        Description = description;
    }
    
    // For use with Entity Framework .NET Core
    protected Category() { }
}