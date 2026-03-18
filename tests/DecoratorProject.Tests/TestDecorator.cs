namespace DecoratorProject.Tests;

using DecoratorProject;


public class TestDecorator {
    
    public static IEnumerable<object[]> IceCreamTestData =>
    new List<object[]>
    {
        new object[] { new CreamyIceCreamDecorator(), new IceCream("small"), "Creamy Ice cream size: small" },
        new object[] { new CreamyIceCreamDecorator(), new IceCream("big"), "Creamy Ice cream size: big" },
        new object[] { new SweetIceCreamDecorator(), new IceCream("small"), "Sweet Ice cream size: small" },
        new object[] { new SweetIceCreamDecorator(), new IceCream("big"), "Sweet Ice cream size: big" },
    };
    
    [Theory]
    [MemberData(nameof(IceCreamTestData))]
    public void TestIceCreamDescriptions(IceCreamDecorator decorator, IceCream iceCream, string expectedDescription) {
        decorator.SetIceCream(iceCream);
        string actualDescription = decorator.GetDescription();
        Console.WriteLine($"Asserting {actualDescription} equals {expectedDescription}");
        Assert.Equal(actualDescription, expectedDescription);
    }

    [Fact]
    public void TestNestedDecorators() {
        CreamyIceCreamDecorator creamyDecorator = new CreamyIceCreamDecorator();
        SweetIceCreamDecorator sweetDecorator = new SweetIceCreamDecorator();
        IceCream smallIceCream = new IceCream("small");

        creamyDecorator.SetIceCream(smallIceCream);
        sweetDecorator.SetIceCream(creamyDecorator);
        string actualDescription = sweetDecorator.GetDescription();
        string expectedDescription = "Sweet Creamy Ice cream size: small";
        Console.WriteLine($"Asserting {actualDescription} equals {expectedDescription}");
        Assert.Equal(actualDescription, expectedDescription);
    }
}
