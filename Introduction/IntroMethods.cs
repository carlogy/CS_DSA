using System.Runtime.CompilerServices;

namespace CS_DSA.Introduction
{
    public static class IntroMethods
    {
        public static int MaxValue(int[] nums)
        {
            var max = int.MinValue;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                }
            }
            return max;
        }
        public static void TestMaxValue()
        {
            Console.WriteLine("Running tests for MaxValue method...");
            var maxValTestCases = new Dictionary<int[], int>();
            maxValTestCases.Add([4, 7, 2, 8, 10, 9], 10);
            maxValTestCases.Add([10, 5, 40, 41], 41);
            maxValTestCases.Add([-5, -2, -1, -11], -1);
            maxValTestCases.Add([42], 42);
            maxValTestCases.Add([1000, 8], 1000);
            maxValTestCases.Add([1000, 8, 9000], 9000);
            maxValTestCases.Add([2, 5, 1, 1, 4], 5);

            var TestsPassed = true;

            foreach (var test in maxValTestCases)
            {
                Console.Write($"Array:\t{string.Join(", ", test.Key)} => {test.Value}\t");
                var actual = IntroMethods.MaxValue(test.Key);
                if (actual != test.Value)
                {
                    TestsPassed = false;
                    Console.Write($"Got:\t{actual}\t Test Failed ❌\n");
                }
                else { Console.Write("Test Passed ✅\n"); }

            }
            if (TestsPassed)
            {
                Console.WriteLine("🎉 All Tests Passed!");
            }
        }

        public static string longestWord(string sentence)
        {
            var stringArr = sentence.Split(" ");
            var longest = "";

            foreach (var word in stringArr)
            {
                if (word.Length >= longest.Length)
                {
                    longest = word;
                }
            }
            return longest;
        }
        public static void TestlongestWord()
        {
            var testsPassed = true;

            var testCases = new Dictionary<string, string>();
            testCases.Add("what a wonderful world", "wonderful");
            testCases.Add("have a nice day", "nice");
            testCases.Add("the quick brown fox jumped over the lazy dog", "jumped");
            testCases.Add("who did eat the ham", "ham");
            testCases.Add("potato", "potato");

            foreach (var test in testCases)
            {
                Console.Write($"Sentence:\t{test.Key} => {test.Value}\t");
                var actual = IntroMethods.longestWord(test.Key);
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

        public static bool isPrime(int n)
        {
            if (n == 0 || n == 1)
            {
                return false;
            }

            for (var i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static void TestisPrime()
        {
            var testsPassed = true;
            var testCases = new Dictionary<int, bool>();
            testCases.Add(2, true);
            testCases.Add(3, true);
            testCases.Add(4, false);
            testCases.Add(5, true);
            testCases.Add(6, false);
            testCases.Add(7, true);
            testCases.Add(8, false);
            testCases.Add(25, false);
            testCases.Add(31, true);
            testCases.Add(2017, true);
            testCases.Add(2048, false);
            testCases.Add(1, false);
            testCases.Add(713, false);

            foreach (var test in testCases)
            {
                Console.Write($"Number:\t{test.Key} => {test.Value}\t");
                var actual = isPrime(test.Key);
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
    }
}