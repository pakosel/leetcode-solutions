using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace MinimumNumberOfSwapsToMakeTheStringBalanced
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"][][", 1},
            new object[] {"]]][[[", 2},
            new object[] {"[]", 0},
            new object[] {"][[[[[[[[[[[[[]]]]]]]]]]]]]]]]]]][[[[[[[[[[][[[[[[[[[[]]]]]]]]]]]]]]]]]]]]][[[[]]]][[[[[[]]]]]][[[[[[[[[[[[[]]]]]]]]]][[[]]]]]]]][[[[[[]][[[[]]]]]][[[[[[[[[", 6},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string s, int expected)
        {
            var sol = new Solution();
            var res = sol.MinSwaps(s);

            Assert.That(expected, Is.EqualTo(res));
        }
    }
}