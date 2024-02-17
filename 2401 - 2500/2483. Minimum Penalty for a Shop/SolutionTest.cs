using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace MinimumPenaltyForShop
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"YYNY", 2},
            new object[] {"NNNNN", 0},
            new object[] {"YYYY", 4},
            new object[] {"Y", 1},
            new object[] {"YY", 2},
            new object[] {"YYY", 3},
            new object[] {"YYYYYYY", 7},
            new object[] {"N", 0},
            new object[] {"NN", 0},
            new object[] {"NNN", 0},
            new object[] {"NNNNNNNN", 0},
            new object[] {"YN", 1},
            new object[] {"NY", 0},
            new object[] {"YNY", 1},
            new object[] {"NYN", 0},
            new object[] {"YNYNYNY", 1},
            new object[] {"YNYNYNYN", 1},
            new object[] {"YNYY", 4},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string customers, int expected)
        {
            var sol = new Solution();
            var res = sol.BestClosingTime(customers);

            ClassicAssert.AreEqual(expected, res);
        }
    }
}