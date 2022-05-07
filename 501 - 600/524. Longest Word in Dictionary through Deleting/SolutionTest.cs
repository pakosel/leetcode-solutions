using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace LongestWordInDictionaryThroughDeleting
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] { "xyz", new string[] {"b","a","c"}, "" },
            new object[] { "abpcplea", new string[] {"b","a","c"}, "a" },
            new object[] { "abpcplea", new string[] {"c","b","a"}, "a" },
            new object[] { "abpcplea", new string[] {"a","b","c"}, "a" },
            new object[] { "abpcplea", new string[] {"ale","apple","monkey","plea"}, "apple" },
            new object[] { "bab", new string[] {"ba","ab","a","b"}, "ab" },
            new object[] { "bab", new string[] {"ab","ba","a","b"}, "ab" },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string s, string[] dict, string expected)
        {
            var sol = new Solution();
            var res = sol.FindLongestWord(s, dict);

            Assert.AreEqual(res, expected);
        }
    }
}