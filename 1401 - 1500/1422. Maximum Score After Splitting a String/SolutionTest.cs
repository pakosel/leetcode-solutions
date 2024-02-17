using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace MaximumScoreAfterSplittingString
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"011101", 5},
            new object[] {"00111", 5},
            new object[] {"1111", 3},
            new object[] {"00", 1},
            new object[] {"11", 1},
            new object[] {"01", 2},
            new object[] {"10", 0},
            new object[] {"000", 2},
            new object[] {"111", 2},
            new object[] {"0000", 3},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string s, int expected)
        {
            var sol = new Solution();
            var res = sol.MaxScore(s);

            Assert.That(expected == res);
        }
    }
}