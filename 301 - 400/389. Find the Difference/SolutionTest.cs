using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;

namespace FindTheDifference
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"", "y", 'y' },
            new object[] {"abcd", "abcde", 'e' },
            new object[] {"aaaccbb", "abcabcax", 'x' },
            new object[] {"aaa", "aaaa", 'a' },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic23(string s, string t, char expected)
        {
            var sol = new Solution_2023();
            var res = sol.FindTheDifference(s, t);

            Assert.That(expected == res);
        }

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string s, string t, char expected)
        {
            var sol = new Solution();
            var res = sol.FindTheDifference(s, t);

            Assert.That(expected == res);
        }
    }
}