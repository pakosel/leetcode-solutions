using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace ShiftingLetters
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] { "a", new int[] {1}, "b" },
            new object[] { "x", new int[] {1}, "y" },
            new object[] { "x", new int[] {2}, "z" },
            new object[] { "x", new int[] {3}, "a" },
            new object[] { "abc", new int[] {3,5,9}, "rpl" },
            new object[] { "xyz", new int[] {3,5,9}, "omi" },
            new object[] { "abb", new int[] {3,0,9}, "mkk" },
            new object[] { "abb", new int[] {16,1111,9}, "sdk" },
            new object[] { "abbc", new int[] {3,1111,9,500}, "ljqi" },
            new object[] { "mkgfzkkuxownxvfvxasy", new int[] {505870226,437526072,266740649,224336793,532917782,311122363,567754492,595798950,81520022,684110326,137742843,275267355,856903962,148291585,919054234,467541837,622939912,116899933,983296461,536563513}, "wqqwlcjnkphhsyvrkdod" },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string S, int[] shifts, string expected)
        {
            var sol = new Solution();
            var res = sol.ShiftingLetters(S, shifts);

            Assert.AreEqual(res, expected);
        }
    }
}