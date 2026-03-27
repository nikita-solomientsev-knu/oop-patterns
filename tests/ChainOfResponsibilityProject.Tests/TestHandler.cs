namespace ChainOfResponsibilityProject.Tests;

using ChainOfResponsibilityProject;

public class TestHandler {
    public static CallCentre callCentre = new CallCentre();
    public static IEnumerable<object[]> QuestionTestData =>
    new List<object[]>
    {
        new object[] { new Question { Value = "Easy question", Priority = 1 }, "Junior response" },
        new object[] { new Question { Value = "Medium question", Priority = 2 }, "Middle response" },
        new object[] { new Question { Value = "Hard question", Priority = 3 }, "Senior response" },
        new object[] { new Question { Value = "Impossible question", Priority = 4 }, "The question had too high priority for the call centre" }
    };
    
    [Theory]
    [MemberData(nameof(QuestionTestData))]
    public void TestAnswers(Question question, string expectedResponse) {
        Assert.Equal(TestHandler.callCentre.Handle(question), expectedResponse);
    }
}
