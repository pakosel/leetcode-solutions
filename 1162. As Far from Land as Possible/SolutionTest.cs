using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace AsFarFromLandAsPossible

{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[[0]]", -1},
            new object[] {"[[1,0,1],[0,0,0],[1,0,1]]", 2},
            new object[] {"[[1,0,0],[0,0,0],[0,0,0]]", 4},
            new object[] {"[[0,0,0],[0,0,0],[0,0,0]]", -1},
            new object[] {"[[0,1,0,0],[1,0,0,1],[0,0,0,1],[0,0,1,0]]", 2},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(string gridStr, int expected)
        {
            int[][] grid;
            var arr = gridStr.TrimStart('[').TrimEnd(']').Split("],[");
            grid = new int[arr.Length][];
            for(int i=0; i<arr.Length; i++)
            {
                var innerArr = arr[i].TrimStart('[').TrimEnd(']').Split(',');
                grid[i] = new int[innerArr.Length];
                for(int j=0; j<innerArr.Length; j++)
                    grid[i][j] = int.Parse(innerArr[j]);
            }

            var sol = new Solution();
            var res = sol.MaxDistance(grid);

            Assert.AreEqual(res, expected);
        }
        
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
        public void Test_Generic(int[][] grid, int expected)
        {
            var sol = new Solution();
            var res = sol.MaxDistance(grid);

            Assert.AreEqual(res, expected);
        }
    }
}