using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;

namespace MinimumAsciiDeleteSumForTwoStrings
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] { "a", "a", 0 },
            new object[] { "a", "x", 217 },
            new object[] { "sea", "eat", 231 },
            new object[] { "delete", "leet", 403 },
            new object[] { "aa", "aaaaaa", 388 },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Example(string s1, string s2, int expected)
        {
            var sol = new Solution();
            var res = sol.MinimumDeleteSum(s1, s2);

            Assert.That(expected == res);
        }
    }
}