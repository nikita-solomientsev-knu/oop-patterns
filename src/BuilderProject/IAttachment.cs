namespace BuilderProject;


public interface IAttachment {
    void Upload(string filename);
    void Download(string filename);
}
