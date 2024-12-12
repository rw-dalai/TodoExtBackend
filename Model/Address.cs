namespace Todo2Backend.Model;

/*
public class Address(string street, string city, string country)
{
    public string Street { get; set; } = street;
    public string City { get; set; } = city;
    public string Country { get; set; } = country;
}
*/

public record Address(string Street, string City, string Country);