using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace ValidSquare
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[[0,0],[0,1],[1,0],[1,1]]", true},
            new object[] {"[[2,6],[2,3],[5,3],[5,6]]", true},
            new object[] {"[[-2,-1],[2,-1],[2,3],[-2,3]]", true},
            new object[] {"[[0,1],[2,-1],[4,1],[2,3]]", true},
            new object[] {"[[-10000,-10000],[-10000,10000],[10000,-10000],[10000,10000]]", true},
            new object[] {"[[0,0],[1,1],[0,0],[0,0]]", false},
            new object[] {"[[0,0],[1,1],[1,1],[0,0]]", false},
            new object[] {"[[0,0],[0,0],[0,0],[0,0]]", false},
            new object[] {"[[0,0],[-1,0],[1,0],[0,1]]", false},
            new object[] {"[[0,0],[1,1],[1,0],[1,1]]", false},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string arrStr, bool expected)
        {
            var points = MatrixFromString(arrStr);

            Assert.IsTrue(points.Length == 4);
            foreach(var p in points)
                Assert.IsTrue(p.Length == 2);

            var sol = new Solution();
            var res = sol.ValidSquare(points[0], points[1], points[2], points[3]);

            Assert.AreEqual(expected, res);
        }

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_WithoutHashSet(string arrStr, bool expected)
        {
            var points = MatrixFromString(arrStr);

            Assert.IsTrue(points.Length == 4);
            foreach(var p in points)
                Assert.IsTrue(p.Length == 2);

            var sol = new Solution_WithoutHashSet();
            var res = sol.ValidSquare(points[0], points[1], points[2], points[3]);

            Assert.AreEqual(expected, res);
        }

        private int[][] MatrixFromString(string matrixStr)
        {
            int[][] matrix;
            var arr = matrixStr.TrimStart('[').TrimEnd(']').Split("],[");
            matrix = new int[arr.Length][];
            for(int i=0; i<arr.Length; i++)
            {
                var innerArr = arr[i].TrimStart('[').TrimEnd(']').Split(',');
                matrix[i] = new int[innerArr.Length];
                for(int j=0; j<innerArr.Length; j++)
                    matrix[i][j] = int.Parse(innerArr[j]);
            }

            return matrix;
        }
    }
}