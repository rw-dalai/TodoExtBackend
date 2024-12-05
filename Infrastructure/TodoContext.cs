namespace Todo2Backend.Infrastructure;

using Microsoft.EntityFrameworkCore;
using Todo2Backend.Model;

public class TodoContext(DbContextOptions<TodoContext> options) : DbContext(options)
{
    public DbSet<User> Users { get; set; }
    public DbSet<Category> Categories { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
    }
}