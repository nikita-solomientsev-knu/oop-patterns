namespace FlyweightProject.Tests;

public class TestFlyweight {
    [Fact]
    public void TestBooks() {
        BookFlyweightFactory factory = new BookFlyweightFactory();

        Book book1 = new Book(
            1,
            2020,
            factory.GetFlyweight("Clean Code", "Robert Martin")
        );

        Book book2 = new Book(
            2,
            2021,
            factory.GetFlyweight("Clean Code", "Robert Martin")
        );

        Book book3 = new Book(
            1,
            2018,
            factory.GetFlyweight("Design Patterns", "Gang of Four")
        );

        Assert.Equal(book1.ToString(), "Title: Clean Code, Author: Robert Martin, Year: 2020, Revision: 1");
        Assert.Equal(book2.ToString(), "Title: Clean Code, Author: Robert Martin, Year: 2021, Revision: 2");
        Assert.Equal(book3.ToString(), "Title: Design Patterns, Author: Gang of Four, Year: 2018, Revision: 1");
    }
}
