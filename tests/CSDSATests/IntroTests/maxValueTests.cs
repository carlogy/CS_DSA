using CS_DSA.Introduction;

public class TestMaxValue
{
    [Fact]
    public void PassedTests()
    {
        var maxValTestCases = new Dictionary<int[], int>();
        maxValTestCases.Add([4, 7, 2, 8, 10, 9], 10);
        maxValTestCases.Add([10, 5, 40, 41], 41);
        maxValTestCases.Add([-5, -2, -1, -11], -1);
        maxValTestCases.Add([42], 42);
        maxValTestCases.Add([1000, 8], 1000);
        maxValTestCases.Add([1000, 8, 9000], 9000);
        maxValTestCases.Add([2, 5, 1, 1, 4], 5);

        foreach (var test in maxValTestCases)
        {
            var actual = IntroMethods.MaxValue(test.Key);
            Assert.Equal(test.Value, actual);
        }
    }
}
