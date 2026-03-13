namespace CompositeProject;


public class CompositeShape: IShape {
    private ArrayList _shapes = new ArrayList();
    private string _name;

    CompositeShape(string name) {
        _name = name;   
    }

    public ArrayList GetPrimitivesNames() {
        ArrayList primitives = new ArrayList {_name};
        foreach (IShape shape in _shapes) {
            primitives.AddRange(shape.GetPrimitivesNames());
        }
        return primitives;
    }
}
