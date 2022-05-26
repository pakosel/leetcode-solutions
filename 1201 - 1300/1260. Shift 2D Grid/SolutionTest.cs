using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace Shift2DGrid
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[[1]]", 0, "[[1]]"},
            new object[] {"[[1]]", 1, "[[1]]"},
            new object[] {"[[1]]", 99, "[[1]]"},
            new object[] {"[[1,2,3],[4,5,6],[7,8,9]]", 99, "[[1,2,3],[4,5,6],[7,8,9]]"},
            new object[] {"[[1,2,3],[4,5,6],[7,8,9]]", 54, "[[1,2,3],[4,5,6],[7,8,9]]"},
            new object[] {"[[1,2],[3,4],[5,6],[7,8],[9,0],[1,2]]", 0, "[[1,2],[3,4],[5,6],[7,8],[9,0],[1,2]]"},
            new object[] {"[[1,2],[3,4],[5,6],[7,8],[9,0],[1,2]]", 1, "[[2,1],[2,3],[4,5],[6,7],[8,9],[0,1]]"},
            new object[] {"[[1,2],[3,4],[5,6],[7,8],[9,0],[1,2]]", 2, "[[1,2],[1,2],[3,4],[5,6],[7,8],[9,0]]"},
            new object[] {"[[1,2],[3,4],[5,6],[7,8],[9,0],[1,2]]", 3, "[[0,1],[2,1],[2,3],[4,5],[6,7],[8,9]]"},
            new object[] {"[[1,2],[3,4],[5,6],[7,8],[9,0],[1,2]]", 13, "[[2,1],[2,3],[4,5],[6,7],[8,9],[0,1]]"},
            new object[] {"[[3,8,1,9],[19,7,2,5],[4,6,11,10],[12,0,21,13]]", 4, "[[12,0,21,13],[3,8,1,9],[19,7,2,5],[4,6,11,10]]"},
            new object[] {"[[1,2,3],[4,5,6],[7,8,9]]", 1, "[[9,1,2],[3,4,5],[6,7,8]]"},
            new object[] {"[[1,2,3],[4,5,6],[7,8,9]]", 9, "[[1,2,3],[4,5,6],[7,8,9]]"},
            new object[] {"[[1],[2],[3],[4],[7],[6],[5]]", 23, "[[6],[5],[1],[2],[3],[4],[7]]"},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(string gridStr, int k, string expectedStr)
        {
            var grid = ArrayHelper.MatrixFromString<int>(gridStr);
            var expected = ArrayHelper.MatrixFromString<int>(expectedStr);

            var sol = new Solution();
            var res = sol.ShiftGrid(grid, k);

            CollectionAssert.AreEqual(res, expected);
        }
    }
}