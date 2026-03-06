namespace SingletonProject.Tests;
using SingletonProject;
using System.Threading;


public class TestSingleton {
    [Fact]
    public void TestSingletonInstance() {
        Assert.Same(Service.GetInstance(), Service.GetInstance());

    }

    [Fact]
    public void TestServiceStatus() {
        Thread workThread = new Thread(() => Service.GetInstance().DoWork("Performing heavy operations"));
        workThread.Start();
        Thread.Sleep(500);
        Assert.Equal("Working", Service.GetInstance().GetStatus());
        Assert.True(workThread.Join(2500));
        Assert.Equal("Idle", Service.GetInstance().GetStatus());
    }
}
