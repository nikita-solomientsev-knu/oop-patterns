namespace CompositeProject;


public class Shape: IShape {
    private string _name;

    Shape(string name) {
        _name = name;
    }

    public ArrayList GetPrimitivesNames() {
        return new ArrayList {_name};
    }
}
