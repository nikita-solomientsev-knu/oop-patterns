using PrototypeProject;
namespace PrototypeProject.Tests;


public class TestPrototype {
    
    [Fact]
    public void TestPrototypeCreation() {
        Computer computerPrototype = Computer.Prototype();
        Console.WriteLine($"Prototype computer:\n{computerPrototype}");
        
        Computer gamingComputer = Computer.GamingPrototype();
        gamingComputer.Ram.Volume = 32;
        Console.WriteLine($"Gaming PC:\n{gamingComputer}");

        Computer officeComputer = computerPrototype.Copy();
        officeComputer.Ram.Volume = 8;
        Console.WriteLine($"Office Computer:\n{officeComputer}");

        Computer personalComputer = computerPrototype.Copy();
        personalComputer.Monitor.Manufacturer = "Lenovo";
        personalComputer.Monitor.Resolution = 26;
        Console.WriteLine($"Personal Computer:\n{personalComputer}");

        Assert.NotEqual(gamingComputer.Gpu.Manufacturer, computerPrototype.Gpu.Manufacturer);
        Assert.NotEqual(gamingComputer.Gpu.Model, computerPrototype.Gpu.Model);
        Assert.NotEqual(officeComputer.Ram.Volume, computerPrototype.Ram.Volume);
        Assert.NotEqual(personalComputer.Monitor.Manufacturer, computerPrototype.Monitor.Manufacturer);
        Assert.NotEqual(personalComputer.Monitor.Resolution, computerPrototype.Monitor.Resolution);
    }
}
