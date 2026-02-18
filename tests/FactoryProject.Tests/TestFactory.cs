using FactoryProject;
namespace FactoryProject.Tests;


public class TestFactory {
    
    [Theory]
    [InlineData("txt", FileType.TXT)]
    [InlineData("png", FileType.PNG)]
    [InlineData("mp3", FileType.MP3)]
    public void TestFactoryProducedExtensions(string expectedExtension, FileType correspondingFileType) {
        FileFactory fileFactory = new FileFactory();
        IFile file = fileFactory.CreateFile("dummy", correspondingFileType);
        Assert.Equal(file.GetExtension(), expectedExtension);
    }
}
