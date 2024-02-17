using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace WidestVerticalAreaBetweenTwoPointsContainingNoPoints
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[[8,7],[9,9],[7,4],[9,7]]", 1},
            new object[] {"[[3,1],[9,0],[1,0],[1,4],[5,3],[8,8]]", 3},
            new object[] {"[[8,7],[18,9],[28,4],[48,7]]", 20},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(string pointsStr, int expected)
        {
            var points = ArrayHelper.MatrixFromString<int>(pointsStr);

            var sol = new Solution();
            var res = sol.MaxWidthOfVerticalArea(points);

            Assert.That(expected == res);
        }
    }
}