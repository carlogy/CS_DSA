using System.ComponentModel;
using System.Net.Http.Headers;
using Xunit.Sdk;

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

    public static void TestPairProduct()
    {
        var testsPassed = true;
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

    public static void TestIntersection()
    {
        var testsPassed = true;
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

            Console.Write($"For:\t{(a.Length < 10 ? String.Join(",", a) : a.Length)}\t{(b.Length < 10 ? String.Join(",", b) : b.Length)}\tExpecting: {(test.Value.Length < 10 ? String.Join(",", test.Value) : test.Value.Length)}\t");

            var actual = HashingExercises.Intersection(a, b);

            if (!ArrayCompare<int>(actual, test.Value))
            // if (!actual.SequenceEqual(test.Value))
            {
                testsPassed = false;
                Console.Write($"Got:\t{(actual.Length < 10 ? String.Join(",", actual) : actual.Length)}\t Test Failed ❌\n");
            }
            else { Console.Write("Test Passed ✅\n"); }
        }
        if (testsPassed)
        {
            Console.WriteLine("🎉 All Tests Passed!");
        }
    }

    public static void TestExclusiveItems()
    {
        var testsPassed = true;
        var testCases = new Dictionary<Tuple<int[], int[]>, int[]>();
        testCases.Add(Tuple.Create(new int[] { 4, 2, 1, 6 }, new int[] { 3, 6, 9, 2, 10 }), new int[] { 4, 1, 3, 9, 10 });
        testCases.Add(Tuple.Create(new int[] { 2, 4, 6 }, new int[] { 4, 2 }), new int[] { 6 });
        testCases.Add(Tuple.Create(new int[] { 4, 2, 1 }, new int[] { 1, 2, 4, 6 }), new int[] { 6 });
        testCases.Add(Tuple.Create(new int[] { 0, 1, 2 }, new int[] { 10, 11 }), new int[] { 0, 1, 2, 10, 11 });

        foreach (var test in testCases)
        {
            var (a, b) = test.Key;

            Console.Write($"For:\t{(a.Length < 10 ? String.Join(",", a) : a.Length)}\t{(b.Length < 10 ? String.Join(",", b) : b.Length)}\tExpecting: {(test.Value.Length < 10 ? String.Join(",", test.Value) : test.Value.Length)}\t");

            var actual = HashingExercises.ExclusiveItems(a, b);

            if (!ArrayCompare<int>(actual, test.Value))
            // if (!actual.SequenceEqual(test.Value))
            {
                testsPassed = false;
                Console.Write($"Got:\t{(actual.Length < 10 ? String.Join(",", actual) : actual.Length)}\t Test Failed ❌\n");
            }
            else { Console.Write("Test Passed ✅\n"); }
        }
        if (testsPassed)
        {
            Console.WriteLine("🎉 All Tests Passed!");
        }

    }

    public static bool ArrayCompare<T>(T[] a, T[] b)
    {
        if (a.Length != b.Length)
        {
            return false;
        }

        var hashA = new Dictionary<object, bool>();

        foreach (var item in a)
        {
            hashA.Add(item, true);
        }

        foreach (var item in b)
        {
            if (!hashA.ContainsKey(item))
            {
                return false;
            }
        }
        return true;
    }
}