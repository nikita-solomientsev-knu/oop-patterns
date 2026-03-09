namespace AdapterProject.Tests;
using AdapterProject;

public class TestAdapter {
    
    [Fact]
    public void TestSending() {
        Sender messageSender = new MessageSender();
        Sender smsSender = new SmsSenderAdapter();
        Sender telegramSender = new TelegramSenderAdapter();
        
        Assert.True(messageSender.Send("Shalom lekulam!", "Lior"));
        Assert.True(smsSender.Send("Ma nishma? Eich avar rosh hashanah?", "Ofer"));
        Assert.True(telegramSender.Send("Kol tov!", "Gili"));
    }
}