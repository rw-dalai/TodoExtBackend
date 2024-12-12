namespace Todo2Backend.Model;

public class User: BaseEntity<int>
{
    public string Name { get; set; }
    public string Email { get; set; }
    public Address Address { get; set; }
    
    // Object-Relational Impedance Mismatch
    // https://en.wikipedia.org/wiki/Object%E2%80%93relational_impedance_mismatch
    private List<Category> _categories = [];
    public IReadOnlyCollection<Category> Categories => _categories.AsReadOnly();
    
    // For use Developer
    public User(string name, string email, Address address)
    {
        Name = name;
        Email = email;
        Address = address;
    }
    
    // For use with Entity Framework .NET Core
    protected User() { }
}