using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace Search2DMatrix
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[[1,3,5,7],[10,11,16,20],[23,30,34,60]]", 3, true},
            new object[] {"[[1,3,5,7],[10,11,16,20],[23,30,34,60]]", 13, false},
            new object[] {"[[1]]", 1, true},
            new object[] {"[[1],[3]]", 3, true},
            new object[] {"[[1]]", 2, false},
            new object[] {"[[1],[3]]", 0, false},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string matrixStr, int target, bool expected)
        {
            var matrix = ArrayHelper.MatrixFromString<int>(matrixStr);

            var sol = new Solution();
            var res = sol.SearchMatrix(matrix, target);

            Assert.That(expected == res);
        }
    }
}