using CS_DSA.Introduction;
public class TestPairs
{
    [Fact]
    public void TestPassed()
    {
        var testCases = new Dictionary<string[], string[][]>();

        testCases.Add(new string[] { "a", "b", "c" }, new string[][] { new string[] { "a", "b" }, new string[] { "a", "c" }, new string[] { "b", "c" } });
        testCases.Add(new string[] { "a", "b", "c", "d" }, new string[][] { new string[] { "a", "b" }, new string[] { "a", "c" }, new string[] { "a", "d" }, new string[] { "b", "c" }, new string[] { "b", "d" }, new string[] { "c", "d" } });
        testCases.Add(new string[] { "cherry", "cranberry", "banana", "blueberry", "lime", "papaya" }, new string[][] { new string[] { "cherry", "cranberry" }, new string[] { "cherry", "banana" }, new string[] { "cherry", "blueberry" }, new string[] { "cherry", "lime" }, new string[] { "cherry", "papaya" }, new string[] { "cranberry", "banana" }, new string[] { "cranberry", "blueberry" }, new string[] { "cranberry", "lime" }, new string[] { "cranberry", "papaya" }, new string[] { "banana", "blueberry" }, new string[] { "banana", "lime" }, new string[] { "banana", "papaya" }, new string[] { "blueberry", "lime" }, new string[] { "blueberry", "papaya" }, new string[] { "lime", "papaya" } });

        foreach (var test in testCases)
        {
            var actual = IntroMethods.Pairs(test.Key);
            Assert.Equal(test.Value, actual);
        }
    }
}


