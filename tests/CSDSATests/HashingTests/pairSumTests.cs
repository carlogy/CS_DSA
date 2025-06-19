using CS_DSA.Hashing;
public class TestPairSum
{
    [Fact]
    public void testsPassed()
    {
        var testCases = new Dictionary<Tuple<int[], int>, int[]>();
        testCases.Add(new Tuple<int[], int>(new int[5] { 3, 2, 5, 4, 1 }, 8), new int[2] { 0, 2 });
        testCases.Add(new Tuple<int[], int>(new int[6] { 4, 7, 9, 2, 5, 1 }, 5), new int[2] { 0, 5 });
        testCases.Add(new Tuple<int[], int>(new int[6] { 4, 7, 9, 2, 5, 1 }, 3), new int[2] { 3, 5 });
        testCases.Add(new Tuple<int[], int>(new int[4] { 1, 6, 7, 2 }, 13), new int[2] { 1, 2 });
        testCases.Add(new Tuple<int[], int>(new int[2] { 9, 9 }, 18), new int[2] { 0, 1 });
        testCases.Add(new Tuple<int[], int>(new int[4] { 6, 4, 2, 8 }, 12), new int[2] { 1, 3 });

        var numbers = new List<int>();

        for (var i = 0; i <= 30000; i++)
        {
            numbers.Add(i);
        }
        testCases.Add(new Tuple<int[], int>(numbers.ToArray(), 59999), new int[2] { 29999, 30000 });

        foreach (var test in testCases)
        {
            var (arr, target) = test.Key;
            var actual = HashingExercises.PairSum(arr, target);
            Assert.Equal(test.Value, actual);
        }
    }
}
