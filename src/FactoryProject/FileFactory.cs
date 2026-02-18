namespace FactoryProject;


public class FileFactory {
    public IFile? CreateFile(string filename, FileType fileType) {
        IFile? file = null;
        switch (fileType) {
            case FileType.PNG:
                file = new PngFile();
                file.Create(filename);
                break;

            case FileType.TXT:
                file =  new TxtFile();
                file.Create(filename);
                break;

            case FileType.MP3:
                file = new Mp3File();
                file.Create(filename);
                break;
        }
        return file;
    }
}
