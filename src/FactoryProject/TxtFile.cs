namespace FactoryProject;


public class TxtFile: IFile {
    public void Create(string filename) {
        Console.WriteLine($"Creating {filename}.txt");
    }

    public string GetExtension() {
        return "txt";
    }
}
