using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace PermutationsII
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[0]", "[[0]]"},
            new object[] {"[0,0]", "[[0,0]]"},
            new object[] {"[0,1]", "[[0,1],[1,0]]"},
            new object[] {"[1,1]", "[[1,1]]"},
            new object[] {"[1,1,1]", "[[1,1,1]]"},
            new object[] {"[1,1,2]", "[[1,1,2],[1,2,1],[2,1,1]]"},
            new object[] {"[1,2,3]", "[[1,2,3],[1,3,2],[2,1,3],[2,3,1],[3,1,2],[3,2,1]]"},
            new object[] {"[0,0,0,1,1,1]", "[[0,0,0,1,1,1],[0,0,1,0,1,1],[0,0,1,1,0,1],[0,0,1,1,1,0],[0,1,0,0,1,1],[0,1,0,1,0,1],[0,1,0,1,1,0],[0,1,1,0,0,1],[0,1,1,0,1,0],[0,1,1,1,0,0],[1,0,0,0,1,1],[1,0,0,1,0,1],[1,0,0,1,1,0],[1,0,1,0,0,1],[1,0,1,0,1,0],[1,0,1,1,0,0],[1,1,0,0,0,1],[1,1,0,0,1,0],[1,1,0,1,0,0],[1,1,1,0,0,0]]"},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_GenericStr(string arrStr, string expectedStr)
        {
            var input = ArrayFromString(arrStr);
            var expected = MatrixFromString(expectedStr);

            var sol = new Solution();
            var res = sol.PermuteUnique(input);

            CollectionAssert.AreEqual(res, expected);
        }

        private int[] ArrayFromString(string arrString)
        {
            var arr = arrString.TrimStart('[').TrimEnd(']').Split(',');
            if(arr[0] == "")
                return new int[0];

            var res = new int[arr.Length];
            for(int i=0; i<arr.Length; i++)
                res[i] = int.Parse(arr[i]);

            return res;
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