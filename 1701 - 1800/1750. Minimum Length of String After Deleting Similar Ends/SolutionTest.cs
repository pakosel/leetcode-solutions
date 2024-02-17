using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace MinimumLengthOfStringAfterDeletingSimilarEnds
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"ca", 2},
            new object[] {"aaaaaaa", 0},
            new object[] {"aabccabba", 3},
            new object[] {"abcabc", 6},
            new object[] {"abccba", 0},
            new object[] {"aabccacba", 1},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string s, int expected)
        {
            var sol = new Solution();
            var res = sol.MinimumLength(s);

            Assert.That(expected == res);
        }
    }
}