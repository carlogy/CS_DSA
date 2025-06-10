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
}