using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace WordBreak
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"leetcode", "[leet,code]", true},
            new object[] {"applepenapple", "[apple,pen]", true},
            new object[] {"catsandog", "[cats,dog,sand,and,cat]", false},
            new object[] {"aaaaaaa", "[aaaa,aaa]", true},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string s, string wordsStr, bool expected)
        {
            var wordsDict = ArrayHelper.ArrayFromString<string>(wordsStr);

            var sol = new Solution();
            var res = sol.WordBreak(s, wordsDict);

            Assert.That(expected == res);
        }
    }
}