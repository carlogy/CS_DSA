using CS_DSA.Hashing;
public class TestMostFrequentChar
{
    public void testsPassed()
    {
        var testCases = new Dictionary<string, char>();
        testCases.Add("bookeeper", 'e');
        testCases.Add("david", 'd');
        testCases.Add("abby", 'b');
        testCases.Add("mississippi", 'i');
        testCases.Add("potato", 'o');
        testCases.Add("eleventennine", 'e');
        testCases.Add("riverbed", 'r');

        foreach (var test in testCases)
        {
            var actual = HashingExercises.MostFrequentChar(test.Key);
            Assert.Equal(test.Value, actual);
        }
    }
}
