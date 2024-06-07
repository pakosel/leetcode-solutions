using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace LongestPalindrome
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"a", 1},
            new object[] {"abccccdd", 7},
            new object[] {"ccc", 3},
            new object[] {"cccdd", 5},
            new object[] {"cccdddd", 7},
            new object[] {"aa", 2},
            new object[] {"aaabbb", 5},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string s, int expected)
        {
            var sol = new Solution();
            var res = sol.LongestPalindrome(s);

            Assert.That(expected == res);
        }

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic2024(string s, int expected)
        {
            var sol = new Solution2024();
            var res = sol.LongestPalindrome(s);

            Assert.That(expected == res);
        }
    }
}