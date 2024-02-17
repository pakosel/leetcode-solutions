using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace CheckIfItIsStraightLine
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[[1,2],[2,3],[3,4],[4,5],[5,6],[6,7]]", true},
            new object[] {"[[1,1],[2,2],[3,4],[4,5],[5,6],[7,7]]", false},
            new object[] {"[[0,0],[0,1],[0,-1]]", true},
            new object[] {"[[0,0],[0,5],[5,0],[1337,0],[0,1337]]", false},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(string pointsStr, bool expected)
        {
            var points = ArrayHelper.MatrixFromString<int>(pointsStr);

            var sol = new Solution();
            var res = sol.CheckStraightLine(points);

            Assert.That(expected == res);
        }
    }
}