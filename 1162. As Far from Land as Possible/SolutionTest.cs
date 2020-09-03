using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace AsFarFromLandAsPossible

{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            //[[0]]
            new object[] {new int[][] {new int[] { 0 }}, -1 },
            //[[1,0,1],[0,0,0],[1,0,1]]
            new object[] {new int[][] {new int[] {1,0,1}, new int[] {0,0,0}, new int[] {1,0,1},}, 2 },
            //[[1,0,0],[0,0,0],[0,0,0]]
            new object[] {new int[][] {new int[] {1,0,0}, new int[] {0,0,0}, new int[] {0,0,0},}, 4 },
            //[[0,0,0],[0,0,0],[0,0,0]]
            new object[] {new int[][] {new int[] {0,0,0}, new int[] {0,0,0}, new int[] {0,0,0},}, -1 },
            //[[0,1,0,0],[1,0,0,1],[0,0,0,1],[0,0,1,0]]
            new object[] {new int[][] {new int[] {0,1,0,0}, new int[] {1,0,0,1}, new int[] {0,0,0,1}, new int[] {0,0,1,0},}, 2 },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Recursive(int[][] grid, int expected)
        {
            var sol = new Solution();
            var res = sol.MaxDistance(grid);

            Assert.AreEqual(res, expected);
        }
    }
}