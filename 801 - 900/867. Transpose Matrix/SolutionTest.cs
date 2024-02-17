using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace TransposeMatrix
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[[1]]", "[[1]]"},
            new object[] {"[[1,2]]", "[[1],[2]]"},
            new object[] {"[[1,2,3],[4,5,6],[7,8,9]]", "[[1,4,7],[2,5,8],[3,6,9]]"},
            new object[] {"[[1,2,3],[4,5,6]]", "[[1,4],[2,5],[3,6]]"},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string matrixStr, string expectedStr)
        {
            var matrix = ArrayHelper.MatrixFromString<int>(matrixStr);
            var expected = ArrayHelper.MatrixFromString<int>(expectedStr);

            var sol = new Solution();
            var res = sol.Transpose(matrix);

            Assert.That(res, Is.EqualTo(expected));
        }
    }
}