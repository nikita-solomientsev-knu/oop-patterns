namespace FlyweightProject;


public class Book {
    public uint Revision { get; }
    public uint Year { get; }
    public BookFlyweight Flyweight { get; }

    public Book(uint revision, uint year, BookFlyweight flyweight)
    {
        Revision = revision;
        Year = year;
        Flyweight = flyweight;
    }

    public string ToString() {
        return $"Title: {Flyweight.Title}, Author: {Flyweight.Author}, Year: {Year}, Revision: {Revision}";
    }
}
