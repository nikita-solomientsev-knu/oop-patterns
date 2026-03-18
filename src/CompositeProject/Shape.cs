namespace CompositeProject;

using System.Collections.Generic;


public class Shape: IShape {
    private string _name;

    public Shape(string name) {
        _name = name;
    }

    public List<string> GetPrimitivesNames() {
        return new List<string> {_name};
    }
}
