namespace ProxyProjectTests;

using ProxyProject;
using System;


public class ProxyTest {
    private static readonly string RESOURCE_FILENAME = Path.Combine(AppContext.BaseDirectory, "index.html");
    
    [Fact]
    public void TestProxyCachingOptimization() {
        uint cacheTtl = 4;
        ServerProxy server = new ServerProxy(ProxyTest.RESOURCE_FILENAME, cacheTtl);
        
        DateTime timestampBeforeRequest = DateTime.Now;
        string content = server.GetResource();
        double diff = (DateTime.Now - timestampBeforeRequest).TotalSeconds;
        Console.WriteLine($"Firest resource request operation time: {diff}");
        Assert.NotInRange(diff, 0, 1);  // operation took 2 seconds
        
        timestampBeforeRequest = DateTime.Now;
        content = server.GetResource();
        diff = (DateTime.Now - timestampBeforeRequest).TotalSeconds;
        Console.WriteLine($"Second resource request operation time: {diff}");
        Assert.InRange(diff, 0, 1);  // operation took less than 1 second
    }
}