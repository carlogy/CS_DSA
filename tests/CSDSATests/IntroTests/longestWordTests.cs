using CS_DSA.Introduction;
public class TestLongestWord
{
    [Fact]
    public void PassedTests()
    {
        var testCases = new Dictionary<string, string>();
        testCases.Add("what a wonderful world", "wonderful");
        testCases.Add("have a nice day", "nice");
        testCases.Add("the quick brown fox jumped over the lazy dog", "jumped");
        testCases.Add("who did eat the ham", "ham");
        testCases.Add("potato", "potato");

        foreach (var test in testCases)
        {
            var actual = IntroMethods.longestWord(test.Key);
            Assert.Equal(test.Value, actual);
        }
    }
}
