namespace CS_DSA.Hashing;

class HashingExercises
{
    public static bool Anagrams(string s1, string s2)
    {
        var s1Dict = new Dictionary<char, int>();

        foreach (var item in s1)
        {
            if (!s1Dict.ContainsKey(item))
            {
                s1Dict.Add(item, 0);
            }
            s1Dict[item]++;
        }

        foreach (var item in s2)
        {
            if (!s1Dict.ContainsKey(item))
            {
                return false;
            }

            s1Dict[item]--;
        }

        foreach (var item in s1Dict)
        {
            if (item.Value != 0)
            {
                return false;
            }
        }
        return true;
    }
    public static char MostFrequentChar(string s1)
    {
        var charCount = new Dictionary<char, int>();

        foreach (var letter in s1)
        {
            if (!charCount.ContainsKey(letter))
            {
                charCount[letter] = 0;
            }
            charCount[letter]++;
        }
        var max = ValueTuple.Create<char, int>(' ', 0);

        foreach (var letter in charCount)
        {
            if (letter.Value > max.Item2)
            {
                max = (letter.Key, letter.Value);
            }
        }
        return max.Item1;
    }

    public static int[] PairSum(int[] nums, int target)
    {
        var count = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            var complement = target - nums[i];
            if (!count.ContainsKey(complement))
            {
                count[nums[i]] = i;
                continue;
            }
            return [count[complement], i];
        }
        return [];
    }
    public static int[] PairProduct(int[] nums, int target)
    {
        var previous = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            var complement = target / nums[i];

            if (!previous.ContainsKey(complement))
            {
                previous[nums[i]] = i;
                continue;
            }
            else
            {
                return [previous[complement], i];
            }
        }
        return [];
    }

    public static int[] Intersection(int[] a, int[] b)
    {
        var setB = b.ToHashSet();
        var diffs = new List<int>();

        foreach (var num in a)
        {
            if (setB.Contains(num))
            {
                diffs.Add(num);
            }
        }
        return diffs.ToArray();
    }

    public static int[] ExclusiveItems(int[] a, int[] b)
    {

        var diffs = new List<int>();
        var setA = a.ToHashSet();
        var setB = b.ToHashSet();

        foreach (var item in setA)
        {
            if (!setB.Contains(item))
            {
                diffs.Add(item);
            }
        }

        foreach (var item in setB)
        {
            if (!setA.Contains(item))
            {
                diffs.Add(item);
            }
        }

        return diffs.ToArray();
    }
}