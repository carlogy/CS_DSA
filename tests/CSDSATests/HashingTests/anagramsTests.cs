using System;
using CS_DSA.Hashing;
using Xunit.Sdk;

namespace CSDSATests;

public class TestAnagrams
{
    [Fact]
    public void testsPassed()
    {
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
            var actual = HashingExercises.Anagrams(s1, s2);
            Assert.Equal(test.Value, actual);
        }
    }
}