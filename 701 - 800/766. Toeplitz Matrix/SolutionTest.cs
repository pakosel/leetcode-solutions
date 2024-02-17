using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

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
        public void Test_Generic2022(string matrixStr, bool expected)
        {
            var matrix = ArrayHelper.MatrixFromString<int>(matrixStr);

            var sol = new Solution_2022();
            var res = sol.IsToeplitzMatrix(matrix);

            ClassicAssert.AreEqual(expected, res);
        }

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string matrixStr, bool expected)
        {
            var matrix = ArrayHelper.MatrixFromString<int>(matrixStr);

            var sol = new Solution();
            var res = sol.IsToeplitzMatrix(matrix);

            ClassicAssert.AreEqual(expected, res);
        }
    }
}