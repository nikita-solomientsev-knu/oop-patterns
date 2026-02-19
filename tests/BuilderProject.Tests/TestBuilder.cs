namespace BuilderProject.Tests;
using BuilderProject;


public class TestBuilder {
    
    [Fact]
    public void TestParameterChange() {
        MessageBuilder builder = new MessageBuilder();
        builder
            .Receiver("Martha")
            .Sender("Farah")
            .Topic("2Q25 tax return")
            .Content("Hi, accounting is doing great");

        var (status, err, message) = builder.Build();

        Assert.True(status);
        Assert.Null(err);
        Assert.NotNull(message);

        string summary = message.GetSummary();

        foreach (string summaryDetail in new[] {"Martha", "Farah", "2Q25"}) {
            Assert.Contains(summaryDetail, summary);
        }

        builder.Receiver("Damian");

        (status, err, message) = builder.Build();

        Assert.True(status);
        Assert.Null(err);
        Assert.NotNull(message);

        summary = message.GetSummary();
        foreach (string summaryDetail in new[] {"Damian", "Farah", "2Q25"}) {
            Assert.Contains(summaryDetail, summary);
        }
        Assert.DoesNotContain("Martha", summary);
    }
}
