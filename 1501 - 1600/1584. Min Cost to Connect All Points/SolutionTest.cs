using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace MinCostToConnectAllPoints
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[[0,0],[2,2],[3,10],[5,2],[7,0]]", 20},
            new object[] {"[[3,12],[-2,5],[-4,1]]", 18},
            new object[] {"[[2,1],[3,1],[6,1],[7,1]]", 5},
            new object[] {"[[-14,-14],[-18,5],[18,-10],[18,18],[10,-2]]", 102},
            new object[] {"[[11,-6],[9,-19],[16,-13],[4,-9],[20,4],[20,7],[-9,18],[10,-15],[-15,3],[6,6]]", 113},
            
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(string pointsStr, int expected)
        {
            var points = ArrayHelper.MatrixFromString<int>(pointsStr);

            var sol = new Solution();
            var res = sol.MinCostConnectPoints(points);

            ClassicAssert.AreEqual(expected, res);
        }
    }
}