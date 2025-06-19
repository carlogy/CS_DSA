using CS_DSA.Introduction;
public class TestIsPrime
{
    [Fact]
    public void TestPassed()
    {
        var testCases = new Dictionary<int, bool>();
        testCases.Add(2, true);
        testCases.Add(3, true);
        testCases.Add(4, false);
        testCases.Add(5, true);
        testCases.Add(6, false);
        testCases.Add(7, true);
        testCases.Add(8, false);
        testCases.Add(25, false);
        testCases.Add(31, true);
        testCases.Add(2017, true);
        testCases.Add(2048, false);
        testCases.Add(1, false);
        testCases.Add(713, false);

        foreach (var test in testCases)
        {
            var actual = IntroMethods.isPrime(test.Key);
            Assert.Equal(test.Value, actual);
        }
    }
}
