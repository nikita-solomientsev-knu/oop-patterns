namespace FactoryProject;


public interface IFile {
    void Create(string filename);
    string GetExtension();
}
