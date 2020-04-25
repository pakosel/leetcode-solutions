using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace LongestPalindromicSubstring
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        [TestCase("", "")]
        [TestCase("a", "a")]
        [TestCase("babad", "bab")]
        [TestCase("cbbd", "bb")]
        [TestCase("abba", "abba")]
        [TestCase("abcba", "abcba")]
        public void Test_Example(string s, string expected)
        {
            var sol = new Solution();
            var ret = sol.LongestPalindrome(s);

            Assert.AreEqual(ret, expected);
        }
    }
}