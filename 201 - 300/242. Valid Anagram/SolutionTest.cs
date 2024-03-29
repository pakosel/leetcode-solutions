using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace ValidAnagram
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"anagram", "nagaram", true},
            new object[] {"rat", "car", false},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic23(string s, string t, bool expected)
        {
            var sol = new Solution_2023();
            var res = sol.IsAnagram(s, t);

            Assert.That(expected == res);
        }

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string s, string t, bool expected)
        {
            var sol = new Solution();
            var res = sol.IsAnagram(s, t);

            Assert.That(expected == res);
        }
    }
}