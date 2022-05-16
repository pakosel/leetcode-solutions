using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace ShortestPathInBinaryMatrix
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[[0,1],[1,0]]", 2},
            new object[] {"[[0,0,0],[1,1,0],[1,1,0]]", 4},
            new object[] {"[[1,0,0],[1,1,0],[1,1,0]]", -1},
            new object[] {"[[1,0],[0,0]]", -1},
            new object[] {"[[0,0,0],[1,1,0],[1,1,1]]", -1},
            new object[] {"[[0,1,0,0,0],[0,1,0,1,0],[0,1,0,1,0],[0,1,0,1,0],[0,0,0,1,0]]", 13},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string gridStr, int expected)
        {
            var grid = ArrayHelper.MatrixFromString(gridStr);

            var sol = new Solution();
            var res = sol.ShortestPathBinaryMatrix(grid);

            Assert.AreEqual(expected, res);
        }
    }
}