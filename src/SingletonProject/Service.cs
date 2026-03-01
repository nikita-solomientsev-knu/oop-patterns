namespace SingletonProject;

using System.Threading;


public sealed class Service {

    private static readonly Service _instance = new Service();
    private volatile bool _isWorking = false;
    private readonly object _workingResource = new object();

    private Service() {}

    public static Service GetInstance() {
        return _instance;
    }

    public void DoWork(string description) {
        lock (_workingResource) {
            _isWorking = true;
            Console.WriteLine($"Working...:\n{description}");
            Thread.Sleep(2000);
            _isWorking = false;
        }
    }

    public string GetStatus() {
        return _isWorking? "Working": "Idle";
    }

}
