namespace BuilderProject;


public class ImageAttachment: IAttachment {
    public void Upload(string filename) {
        Console.WriteLine($"Uploading {filename} image file");
    }
    
    public void Download(string filename) {
        Console.WriteLine($"Downloading {filename} image file");
    }
}

