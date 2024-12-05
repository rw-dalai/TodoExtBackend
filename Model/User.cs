namespace Todo2Backend.Model;

public class User: BaseEntity<int>
{
    public string Name { get; set; }
    public string Email { get; set; }
    
    private List<Category> _categories = [];
    public IReadOnlyCollection<Category> Categories => _categories.AsReadOnly();
    
    // For use Developer
    public User(string name, string email)
    {
        Name = name;
        Email = email;
    }
    
    // For use with Entity Framework .NET Core
    protected User() { }
}