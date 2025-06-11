namespace CS_DSA.Hashing;
public static class HashTests
{
    public static void TestAnagrams()
    {
        var testsPassed = true;

        var testCases = new Dictionary<Tuple<string, string>, bool>();
        testCases.Add(Tuple.Create("restful", "fluster"), true);
        testCases.Add(Tuple.Create("cats", "tocs"), false);
        testCases.Add(Tuple.Create("monkeyswrite", "newyorktimes"), true);
        testCases.Add(Tuple.Create("paper", "reapa"), false);
        testCases.Add(Tuple.Create("elbow", "below"), true);
        testCases.Add(Tuple.Create("tax", "taxi"), false);
        testCases.Add(Tuple.Create("taxi", "tax"), false);
        testCases.Add(Tuple.Create("night", "thing"), true);
        testCases.Add(Tuple.Create("abbc", "aabc"), false);
        testCases.Add(Tuple.Create("po", "popp"), false);
        testCases.Add(Tuple.Create("pp", "oo"), false);


        foreach (var test in testCases)
        {
            var (s1, s2) = test.Key;
            Console.Write($"For:\t{s1}, {s2}\tExpecting: {test.Value}\t");
            var actual = HashingExercises.Anagrams(s1, s2);
            if (actual != test.Value)
            {
                testsPassed = false;
                Console.Write($"Got:\t{actual}\t Test Failed ❌\n");
            }
            else { Console.Write("Test Passed ✅\n"); }

        }
        if (testsPassed)
        {
            Console.WriteLine("🎉 All Tests Passed!");
        }
    }

    public static void TestMostFrequentChar()
    {
        var testsPassed = true;
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
            Console.Write($"For:\t{test.Key}\tExpecting: {test.Value}\t");
            var actual = HashingExercises.MostFrequentChar(test.Key);
            if (actual != test.Value)
            {
                testsPassed = false;
                Console.Write($"Got:\t{actual}\t Test Failed ❌\n");
            }
            else { Console.Write("Test Passed ✅\n"); }
        }
        if (testsPassed)
        {
            Console.WriteLine("🎉 All Tests Passed!");
        }
    }

    public static void TestPairSum()
    {
        var testsPassed = true;
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
            Console.Write($"For:\t{(arr.Length < 10 ? String.Join(",", arr) : arr.Length)}\t{target}\tExpecting: {String.Join(",", test.Value)}\t");
            var actual = HashingExercises.PairSum(arr, target);
            if (!actual.SequenceEqual(test.Value))
            {
                testsPassed = false;
                Console.Write($"Got:\t{String.Join(",", actual)}\t Test Failed ❌\n");
            }
            else { Console.Write("Test Passed ✅\n"); }
        }
        if (testsPassed)
        {
            Console.WriteLine("🎉 All Tests Passed!");
        }

    }
}