using CS_DSA.Hashing;
public class TestIntersection
{
    [Fact]
    public void testsPassed()
    {
        var testCases = new Dictionary<Tuple<int[], int[]>, int[]>();
        testCases.Add(Tuple.Create(new int[4] { 4, 2, 1, 6 }, new int[5] { 3, 6, 9, 2, 10 }), new int[2] { 2, 6 });
        testCases.Add(Tuple.Create(new int[3] { 2, 4, 6 }, new int[2] { 4, 2 }), new int[2] { 2, 4 });
        testCases.Add(Tuple.Create(new int[3] { 4, 2, 1 }, new int[4] { 1, 2, 4, 6 }), new int[3] { 1, 2, 4 });
        testCases.Add(Tuple.Create(new int[3] { 0, 1, 2 }, new int[2] { 10, 11 }), new int[] { });

        var nums = new List<int>();
        for (var i = 0; i <= 30000; i++)
        {
            nums.Add(i);
        }
        testCases.Add(Tuple.Create(nums.ToArray(), nums.ToArray()), nums.ToArray());

        foreach (var test in testCases)
        {
            var (a, b) = test.Key;
            var actual = HashingExercises.Intersection(a, b);
            Assert.Equivalent(test.Value, actual);
        }
    }
}
