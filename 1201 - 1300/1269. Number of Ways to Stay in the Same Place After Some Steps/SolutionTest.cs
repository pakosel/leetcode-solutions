using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace NumberOfWaysToStayInTheSamePlaceAfterSomeSteps
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {3, 2, 4},
            new object[] {2, 4, 2},
            new object[] {4, 2, 8},
            new object[] {1, 1, 1},
            new object[] {500, 1000, 374847123},
            new object[] {500, 1000000, 374847123},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(int steps, int arrLen, int expected)
        {
            var sol = new Solution();
            var res = sol.NumWays(steps, arrLen);

            ClassicAssert.AreEqual(expected, res);
        }
    }
}