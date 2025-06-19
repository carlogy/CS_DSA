using CS_DSA.Hashing;
public class TestPairProduct
{
    public void TestPassed()
    {
        var testCases = new Dictionary<Tuple<int[], int>, int[]>();
        testCases.Add(Tuple.Create(new int[5] { 3, 2, 5, 4, 1 }, 8), new int[2] { 1, 3 });
        testCases.Add(Tuple.Create(new int[5] { 3, 2, 5, 4, 1 }, 10), new int[2] { 1, 2 });
        testCases.Add(Tuple.Create(new int[6] { 4, 7, 9, 2, 5, 1 }, 4), new int[2] { 4, 5 });
        testCases.Add(Tuple.Create(new int[6] { 4, 7, 9, 2, 5, 1 }, 35), new int[2] { 1, 4 });
        testCases.Add(Tuple.Create(new int[5] { 3, 2, 5, 4, 1 }, 10), new int[2] { 1, 2 });
        testCases.Add(Tuple.Create(new int[4] { 4, 6, 8, 2 }, 16), new int[2] { 2, 3 });

        var nums = new List<int>();
        for (var i = 0; i <= 30000; i++)
        {
            nums.Add(i);
        }

        testCases.Add(Tuple.Create(nums.ToArray(), 899970000), new int[2] { 29999, 30000 });

        foreach (var test in testCases)
        {
            var (arr, target) = test.Key;
            var actual = HashingExercises.PairProduct(arr, target);
            Assert.Equal(test.Value, actual);
        }
    }
}
