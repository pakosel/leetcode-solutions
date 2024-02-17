using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace LongestSubstringWithoutRepeatingCharacters
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"a", 1},
            new object[] {"abcabcbb", 3},
            new object[] {"abcddcba", 4},
            new object[] {"axwabcdefgahij", 10},
            new object[] {"bbbbb", 1},
            new object[] {"pwwkew", 3},
            new object[] {"abcdefghijklmnopqrstuvwxyz ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()-=_+`~[]{};':,./<>?\"\\|", 95},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string s, int expected)
        {
            var sol = new Solution();
            var res = sol.LengthOfLongestSubstring(s);

            Assert.That(expected == res);
        }
        
        [Test]
        [TestCaseSource("testCases")]
        public void Test_Old(string s, int expected)
        {
            var sol = new Solution2020();
            var res = sol.LengthOfLongestSubstring(s);

            Assert.That(expected == res);
        }
    }
}