namespace CompositeProject;

using System.Collections.Generic;


public class CompositeShape: IShape {
    private List<IShape> _shapes = new List<IShape>();
    private string _name;

    public CompositeShape(string name, List<IShape> shapes) {
        _name = name;
        _shapes.AddRange(shapes);
    }

    public List<string> GetPrimitivesNames() {
        List<string> primitives = new List<string> {_name};
        foreach (IShape shape in _shapes) {
            primitives.AddRange(shape.GetPrimitivesNames());
        }
        return primitives;
    }
}
