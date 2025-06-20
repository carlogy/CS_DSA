using CS_DSA.Hashing;

public class TestAllUnique
{
    [Fact]
    public void TestsPassed()
    {
        var testCases = new Dictionary<string[], bool>();
        testCases.Add(new string[] { "q", "r", "s", "a" }, true);
        testCases.Add(new string[] { "q", "r", "s", "a", "r", "z" }, false);
        testCases.Add(new string[] { "red", "blue", "yellow", "green", "orange" }, true);
        testCases.Add(new string[] { "cat", "cat", "dog" }, false);
        testCases.Add(new string[] { "a", "u", "t", "u", "m", "n" }, false);

        foreach (var test in testCases)
        {
            var actual = HashingExercises.AllUnique(test.Key);
            Assert.Equal(test.Value, actual);
        }
    }

}