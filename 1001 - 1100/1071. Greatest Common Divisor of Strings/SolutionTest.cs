using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace GreatestCommonDivisorOfStrings
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"A", "A", "A"},
            new object[] {"A", "AA", "A"},
            new object[] {"ABCABC", "ABC", "ABC"},
            new object[] {"ABABAB", "ABAB", "AB"},
            new object[] {"LEET", "CODE", ""},
            new object[] {"ABCXXXXABC", "QQQXXXXXWW", ""},
            new object[] {"XYXY", "XYXYXYXY", "XYXY"},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string str1, string str2, string expected)
        {
            var sol = new Solution();
            var res = sol.GcdOfStrings(str1, str2);

            Assert.That(expected == res);
        }
    }
}