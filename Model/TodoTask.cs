namespace Todo2Backend.Model;

public class TodoTask : BaseEntity<int>
{
    public string Title { get; set; }
    public bool IsComplete { get; set; }
    public DateTime DueAt { get; set; }
    
    // Navigation Property
    public TodoItem TodoItem { get; set; }
    
    // For use Developer
    public TodoTask(string title, bool isComplete, DateTime dueAt)
    {
        Title = title;
        IsComplete = isComplete;
        DueAt = dueAt;
    }
    
    // For use with Entity Framework .NET Core
    protected TodoTask() { }
}