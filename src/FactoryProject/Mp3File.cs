namespace FactoryProject;


public class Mp3File: IFile {
    public void Create(string filename) {
        Console.WriteLine($"Creating {filename}.mp3");
    }

    public string GetExtension() {
        return "mp3";
    }
}
