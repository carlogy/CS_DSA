using CS_DSA.Introduction;
public class TestFizzBuzz
{
    [Fact]
    public void TestPassed()
    {
        var testCases = new Dictionary<int, List<Object>>();

        testCases.Add(11, new List<Object> { 1, 2, "fizz", 4, "buzz", "fizz", 7, 8, "fizz", "buzz", 11 });
        testCases.Add(2, new List<object> { 1, 2 });
        testCases.Add(16, new List<object> { 1, 2, "fizz", 4, "buzz", "fizz", 7, 8, "fizz", "buzz", 11, "fizz", 13, 14, "fizzbuzz", 16 });
        testCases.Add(32, new List<object> { 1, 2, "fizz", 4, "buzz", "fizz", 7, 8, "fizz", "buzz", 11, "fizz", 13, 14, "fizzbuzz", 16, 17, "fizz", 19, "buzz", "fizz", 22, 23, "fizz", "buzz", 26, "fizz", 28, 29, "fizzbuzz", 31, 32 });

        foreach (var test in testCases)
        {
            var actual = IntroMethods.fizzBuzz(test.Key);
            Assert.Equal(test.Value, actual);
        }
    }
}