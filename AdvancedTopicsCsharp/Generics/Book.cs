namespace Generics;

public class Book
{
    public Book(string name, double year)
    {
        Name = name;
        Year = year;
    }

    public string Name { get; set; }

    public double Year { get; set; }
}