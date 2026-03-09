namespace ProxyProject;

using System.IO;
using System;


public class Server: IServer {
    private string _filename;

    public Server(string filename) {
        _filename = filename;
    }

    public string GetResource() {
        Thread.Sleep(2000);  // simulate time consuming task
        return File.ReadAllText(_filename);
    }

}
