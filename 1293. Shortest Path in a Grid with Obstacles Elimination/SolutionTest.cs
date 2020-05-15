using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace ShortestPathInGridWithObstacles
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {new int[][] {new int[] {0,0,0},
                                       new int[] {1,1,0},
                                       new int[] {0,0,0},
                                       new int[] {0,1,1},
                                       new int[] {0,0,0}}, 1, 6},
            new object[] {new int[][] {new int[] {0,1,1},
                                       new int[] {1,1,1},
                                       new int[] {1,0,0}}, 1, -1},
            new object[] {new int[][] {new int[] {0,0,0},
                                       new int[] {1,1,0},
                                       new int[] {0,0,0},
                                       new int[] {0,1,1},
                                       new int[] {0,0,0}}, 0, 10},
            new object[] {new int[][] {new int[] {0,0,1,0,0,0,0,1,0,1,1,0,0,1,1},
                                       new int[] {0,0,0,1,1,0,0,1,1,0,1,0,0,0,1},
                                       new int[] {1,1,0,0,0,0,0,1,0,1,0,0,1,0,0},
                                       new int[] {1,0,1,1,1,1,0,0,1,1,0,1,0,0,1},
                                       new int[] {1,0,0,0,1,1,0,1,1,0,0,1,1,1,1},
                                       new int[] {0,0,0,1,1,1,0,1,1,0,0,1,1,1,1},
                                       new int[] {0,0,0,1,0,1,0,0,0,0,1,1,0,1,1},
                                       new int[] {1,0,0,1,1,1,1,1,1,0,0,0,1,1,0},
                                       new int[] {0,0,1,0,0,1,1,1,1,1,0,1,0,0,0},
                                       new int[] {0,0,0,1,1,0,0,1,1,1,1,1,1,0,0},
                                       new int[] {0,0,0,0,1,1,1,0,0,1,1,1,0,1,0}}, 27, 24},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(int[][] grid, int k, int expected)
        {
            var sol = new Solution();
            var res = sol.ShortestPath(grid, k);

            Assert.AreEqual(res, expected);
        }
    }
}