namespace InterpreterProject.Tests;

using InterpreterProject;


public class TestInterpreter {
    public static IEnumerable<object[]> TestData =>
    new List<object[]>
    {
        new object[] { "1+2", 3 },
        new object[] { "2+1", 3 },
        new object[] { "1-2", -1 },
        new object[] { "2-1", 1 },
        new object[] { "2-1-1", 0 },
        new object[] { "1+3*2", 7 },
        new object[] { "2*3+2", 8 },
        new object[] { "2*3+4/2", 8 },
        new object[] { "1*2-3+6/3", 1 },
        
    };
    
    [Theory]
    [MemberData(nameof(TestData))]
    public void TestPositive(string input, int expected_result) {
        Assert.Equal(expected_result, new Interpretator(input).Interpretate());
    }
}
