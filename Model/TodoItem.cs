using Microsoft.VisualBasic;

namespace Todo2Backend.Model;

public class TodoItem : BaseEntity<int>
{
    public string Title { get; set; }
    public string Description { get; set; }
    public Category Category { get; set; }
    
    // Until that date we have to finish the todo item
    public DateTime DueAt { get; set; }
    
    // Navigation Property
    private List<TodoTask> _totoTasks = [];
    public IReadOnlyCollection<TodoTask> TodoTasks => _totoTasks.AsReadOnly();
    
    // For use Developer
    public TodoItem(string title, string description, Category category, DateTime dueAt)
    {
        Title = title;
        Description = description;
        Category = category;
        DueAt = dueAt;
    }
    
    // For use with Entity Framework .NET Core
    protected TodoItem() { }
}