using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace CountNumberOfHomogenousSubstrings
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"a", 1},
            new object[] {"xy", 2},
            new object[] {"abbcccaa", 13},
            new object[] {"zzzzz", 15},
            new object[] {"abbcccaazzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzabbcccaaabbcccaazzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzabbcccaa", 2124},
            new object[] {"abbcccaazzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzabbcccaaabbcccaazzzzzzzzzzzzzzzzzzzzzzzzzzzzzabbcccaazzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzabbcccaazzzzzzzzzzzzzzzzabbcccaa", 2721},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string s, int expected)
        {
            var sol = new Solution();
            var res = sol.CountHomogenous(s);

            Assert.That(expected == res);
        }

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic2023(string s, int expected)
        {
            var sol = new Solution_2023();
            var res = sol.CountHomogenous(s);

            Assert.That(expected == res);
        }
    }
}