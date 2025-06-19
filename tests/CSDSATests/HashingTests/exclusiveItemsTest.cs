using CS_DSA.Hashing;
public class TestExclusiveItems
{
    [Fact]
    public void testsPassed()
    {
        var testCases = new Dictionary<Tuple<int[], int[]>, int[]>();
        testCases.Add(Tuple.Create(new int[] { 4, 2, 1, 6 }, new int[] { 3, 6, 9, 2, 10 }), new int[] { 4, 1, 3, 9, 10 });
        testCases.Add(Tuple.Create(new int[] { 2, 4, 6 }, new int[] { 4, 2 }), new int[] { 6 });
        testCases.Add(Tuple.Create(new int[] { 4, 2, 1 }, new int[] { 1, 2, 4, 6 }), new int[] { 6 });
        testCases.Add(Tuple.Create(new int[] { 0, 1, 2 }, new int[] { 10, 11 }), new int[] { 0, 1, 2, 10, 11 });

        foreach (var test in testCases)
        {
            var (a, b) = test.Key;
            var actual = HashingExercises.ExclusiveItems(a, b);
            Assert.Equivalent(test.Value, actual);
        }
    }
}
