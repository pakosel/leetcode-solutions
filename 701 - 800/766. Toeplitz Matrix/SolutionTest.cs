using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace ToeplitzMatrix

{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[[0]]", true},
            new object[] {"[[1,2]]", true},
            new object[] {"[[1,2],[2,2]]", false},
            new object[] {"[[1,2,3,4],[5,1,2,3],[9,5,1,2]]", true},
            new object[] {"[[1,2,3,4],[5,1,2,3],[9,6,1,2]]", false},
            new object[] {"[[11,74,0,93],[40,11,74,7]]", false},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_GenericStr(string matrixStr, bool expected)
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

            var sol = new Solution();
            var res = sol.IsToeplitzMatrix(matrix);

            Assert.AreEqual(expected, res);
        }
    }
}