using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace WordPattern
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] { "abba", "dog cat cat dog", true },
            new object[] { "abba", "dog cat cat fish", false },
            new object[] { "aaaa", "dog cat cat dog", false },
            new object[] { "a", "dog cat cat dog", false },
            new object[] { "abc", "dog cat cat", false },
            new object[] { "abcbd", "abba baba cacy baba ddd", true },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string pattern, string s, bool expected)
        {
            var sol = new Solution();
            var res = sol.WordPattern(pattern, s);

            Assert.AreEqual(res, expected);
        }
    }
}