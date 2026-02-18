namespace FactoryProject;


public class PngFile: IFile {
    public void Create(string filename) {
        Console.WriteLine($"Creating {filename}.png");
    }

    public string GetExtension() {
        return "png";
    }
}
