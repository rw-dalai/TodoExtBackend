namespace Todo2Backend.Infrastructure;

using Microsoft.EntityFrameworkCore;
using Todo2Backend.Model;

// Convention over Configuration
public class TodoContext(DbContextOptions<TodoContext> options) : DbContext(options)
{
    // 1. Create the Database Tables (Pluralized)
    public DbSet<User> Users { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<TodoItem> TodoItems { get; set; }
    public DbSet<TodoTask> TodoTasks { get; set; }
    
    // 2. Configure the Database Model
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // modelBuilder.Owned<Address>();
        modelBuilder.Entity<User>().OwnsOne(u => u.Address );
    }
}