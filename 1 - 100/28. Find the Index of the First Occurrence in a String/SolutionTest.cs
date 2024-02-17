using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace FindTheIndexOfTheFirstOccurrenceInString
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"sadbutsad", "sad", 0},
            new object[] {"leetcode", "leeto", -1},
            new object[] {"a", "a", 0},
            new object[] {"a", "b", -1},
            new object[] {"a", "ab", -1},
            new object[] {"aaaaaaaaab", "aaaaab", 4},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string haystack, string needle, int expected)
        {
            var sol = new Solution();
            var res = sol.StrStr(haystack, needle);

            Assert.That(expected == res);
        }
    }
}