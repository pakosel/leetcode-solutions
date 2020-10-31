using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace PermutationInString
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] { "a", "eidbaooo", true },
            new object[] { "x", "eidbaooo", false },
            new object[] { "o", "eidbaooo", true },
            new object[] { "ab", "eidbaooo", true },
            new object[] { "ab", "eidboaoo", false },
            new object[] { "abcd", "abc", false },
            new object[] { "abcd", "abcd", true },
            new object[] { "a", "a", true },
            new object[] { "a", "x", false },
            new object[] { "aa", "a", false },
            new object[] { "adc", "dcda", true },
            new object[] { "adc", "cdcda", true },
            new object[] { "adc", "cdda", false },
            new object[] { "hello", "ooolleoooleh", false },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string s1, string s2, bool expected)
        {
            var sol = new Solution();
            var res = sol.CheckInclusion(s1, s2);

            Assert.AreEqual(res, expected);
        }
    }
}