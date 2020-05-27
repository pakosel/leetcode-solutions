using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace ConcatenatedWords
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] { new string[] {""}, new string[]{} },
            new object[] { new string[] {"cat","cats","catsdogcats","dog","dogcatsdog","hippopotamuses","rat","ratcatdogcat"}, new string[]{"catsdogcats","dogcatsdog","ratcatdogcat"} },
            new object[] { new string[] {"rfkqyuqfjkx","","vnrtysfrzrmzl"}, new string[]{} },
            new object[] { new string[] {"rfkqyuqfjkx","","vnrtysfrzrmzl","vnrtysfrzrmzlrfkqyuqfjkx"}, new string[]{"vnrtysfrzrmzlrfkqyuqfjkx"} },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string[] words, string[] expected)
        {
            var sol = new Solution();
            var res = sol.FindAllConcatenatedWordsInADict(words);

            CollectionAssert.AreEquivalent(res, expected);
        }
    }
}