using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Todo2Backend.Infrastructure;
using Xunit;

namespace Todo2Backend.Test;

public class TodoContextTest
{
    private TodoContext TodoContext()
    {
        // Setup SQLite In-Memory Database
        var connection = new SqliteConnection("DataSource=:memory:");
        connection.Open();
         
        // Setup Database Options like Logging for easier debugging
        var options = new DbContextOptionsBuilder<TodoContext>()
        .UseSqlite(connection)
        .EnableSensitiveDataLogging()
        .LogTo(Console.WriteLine)
        .Options;
         
        // Create the DbContext
        var db = new TodoContext(options);

        // Start with empty test database
        db.Database.EnsureDeleted();
        db.Database.EnsureCreated();
         
        // Seed for testing
        // 
         
        // Return the Database Context
        return db;
    }
    
    
    [Fact]
    public void Should_CreateDatabaseSchema()
    {
        // This test verifies that our database schema can be created.
        // If there are any issues with our entity configurations, this will fail.
        TodoContext();
    }
}