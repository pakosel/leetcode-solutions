using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace MergeIntervals

{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[]", "[]"},
            new object[] {"[[1,3]]", "[[1,3]]"},
            new object[] {"[[1,3],[5,10]]", "[[1,3],[5,10]]"},
            new object[] {"[[1,3],[2,6],[8,10],[15,18]]", "[[1,6],[8,10],[15,18]]"},
            new object[] {"[[15,18],[1,3],[2,6],[2,3],[8,10],[1,3]]", "[[1,6],[8,10],[15,18]]"},
            new object[] {"[[1,3],[2,6],[8,10],[15,18],[2,50]]", "[[1,50]]"},
            new object[] {"[[1,4],[4,5]]", "[[1,5]]"},
            new object[] {"[[1,3],[2,5],[4,4],[5,11]]", "[[1,11]]"},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(string intervalsStr, string expected)
        {
            var intervals = StrMatrixToArray(intervalsStr);
            var sol = new Solution();
            var res = sol.Merge(intervals);

            Assert.AreEqual(MatrixArrayToStr(res), expected);
        }

        public int[][] StrMatrixToArray(string matrixStr)
        {
            if(matrixStr == "[]")
                return new int[0][];

            int[][] matrix;
            var arr = matrixStr.TrimStart('[').TrimEnd(']').Split("],[");
            matrix = new int[arr.Length][];
            for (int i = 0; i < arr.Length; i++)
            {
                var innerArr = arr[i].TrimStart('[').TrimEnd(']').Split(',');
                matrix[i] = new int[innerArr.Length];
                for (int j = 0; j < innerArr.Length; j++)
                    matrix[i][j] = int.Parse(innerArr[j]);
            }

            return matrix;
        }

        public string MatrixArrayToStr(int[][] matrix)
        {
            if(matrix.Length == 0)
                return "[]";

            StringBuilder sb = new StringBuilder();
            sb.Append('[');
            sb.Append(string.Join(',', matrix.Select(it => "[" + string.Join(',', it) + "]")));
            sb.Append(']');

            return sb.ToString();
        }
    }
}