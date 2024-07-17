using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace MaximumScoreFromRemovingSubstrings
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"cdbcbbaaabab", 4, 5, 19},
            new object[] {"aabbaaxybbaabb", 5, 4, 20},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string s, int x, int y, int expected)
        {
            var sol = new Solution();
            var res = sol.MaximumGain(s, x, y);

            Assert.That(expected, Is.EqualTo(res));
        }
    }
}