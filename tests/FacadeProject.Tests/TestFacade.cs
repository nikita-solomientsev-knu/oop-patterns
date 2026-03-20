namespace FacadeProject.Tests;

using FacadeProject;


public class TestFacade
{
    [Fact]
    public void TestComputerTurnOn() {
        Computer computer = new Computer();

        Assert.False(computer.IsOn());
        computer.TurnOn();
        
        Assert.True(computer.IsOn());
    }
}