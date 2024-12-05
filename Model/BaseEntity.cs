namespace Todo2Backend.Model;

public abstract class BaseEntity<T>() where T : struct
{
    // EF Core uses the Id property as the primary key by convention.
    public T Id { get; set; }
}