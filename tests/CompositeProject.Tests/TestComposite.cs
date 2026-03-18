namespace CompositeProject.Tests;

using CompositeProject;


public class TestComposite {
    
    [Fact]
    public void TestRecursiveComposition() {
        
        Shape shapeA = new Shape("a");
        Shape shapeB = new Shape("b");
        Shape shapeC = new Shape("c");
        
        CompositeShape compositeShapeD = new CompositeShape("d", new List<IShape> {shapeA, shapeB});
        CompositeShape compositeShapeE = new CompositeShape("e", new List<IShape> {shapeC, compositeShapeD});
        
        List<string> primitives = compositeShapeE.GetPrimitivesNames();
        
        Console.WriteLine($"Checking if list is valid {primitives}");
        Assert.Equal(primitives.OrderBy(x => x), new List<string> {"a", "b", "c", "d", "e"}.OrderBy(x => x));
        
    }
}