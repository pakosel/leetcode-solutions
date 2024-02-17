using System;
using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace MaxIncreaseToKeepCitySkyline
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[[0,0,0],[0,0,0],[0,0,0]]", 0},
            new object[] {"[[3,0,8,4],[2,4,5,7],[9,2,6,3],[0,3,1,0]]", 35},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string strGrid, int expected)
        {
            var grid = ArrayHelper.MatrixFromString<int>(strGrid);

            var sol = new Solution();
            var res = sol.MaxIncreaseKeepingSkyline(grid);

            ClassicAssert.AreEqual(expected, res);
        }
    }
}