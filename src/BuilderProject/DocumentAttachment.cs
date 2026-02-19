namespace BuilderProject;


public class DocumentAttachment: IAttachment {
    public void Upload(string filename) {
        Console.WriteLine($"Uploading {filename} doc file");
    }

    public void Download(string filename) {
        Console.WriteLine($"Downloading {filename} doc file");
    }
}