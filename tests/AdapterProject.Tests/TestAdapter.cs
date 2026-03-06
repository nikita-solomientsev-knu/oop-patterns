namespace AdapterProject.Tests;
using AdapterProject;

public class TestAdapter {
    
    [Fact]
    public void TestSending() {
        Sender messageSender = new MessageSender();
        Sender smsSender = new SmsSenderAdapter();
        
        Assert.True(messageSender.Send("Lior", "Shalom lekulam!"));
        Assert.True(smsSender.Send("Ofer", "Ma nishma? Eich avar rosh hashanah?"));
    }
}