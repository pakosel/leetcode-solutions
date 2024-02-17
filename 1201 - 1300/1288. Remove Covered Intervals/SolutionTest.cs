using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace RemoveCoveredIntervals
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[[1,4],[2,3]]", 1},
            new object[] {"[[1,4],[3,6],[2,8]]", 2},
            new object[] {"[[1,2],[1,4],[3,4]]", 1},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(string intervalsStr, int expected)
        {
            var intervals = ArrayHelper.MatrixFromString<int>(intervalsStr);

            var sol = new Solution();
            var res = sol.RemoveCoveredIntervals(intervals);

            ClassicAssert.AreEqual(expected, res);
        }
    }
}