using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;

namespace FlippingImage

{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[[0]]", "[[1]]"},
            new object[] {"[[1,1,0],[1,0,1],[0,0,0]]", "[[1,0,0],[0,1,0],[1,1,1]]"},
            new object[] {"[[1,1,0,0],[1,0,0,1],[0,1,1,1],[1,0,1,0]]", "[[1,1,0,0],[0,1,1,0],[0,0,0,1],[1,0,1,0]]"},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_GenericStr(string matrixStr, string expectedStr)
        {
            int[][] input = MatrixFromString(matrixStr);            
            int[][] expected = MatrixFromString(expectedStr);

            var sol = new Solution();
            var res = sol.FlipAndInvertImage(input);

            CollectionAssert.AreEqual(expected, res);
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