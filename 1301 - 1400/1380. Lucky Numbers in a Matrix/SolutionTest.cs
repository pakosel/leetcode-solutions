using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;
using System;

namespace LuckyNumbersInMatrix
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[[3,7,8],[9,11,13],[15,16,17]]", "[15]"},
            new object[] {"[[1,10,4,2],[9,3,8,7],[15,16,17,12]]", "[12]"},
            new object[] {"[[7,8],[1,2]]", "[7]"},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(string matrixStr, string expectedStr)
        {
            var matrix = ArrayHelper.MatrixFromString<int>(matrixStr);
            var expected = ArrayHelper.ArrayFromString<int>(expectedStr);

            var sol = new Solution();
            var res = sol.LuckyNumbers(matrix);

            Assert.That(expected, Is.EqualTo(res));
        }
    }
}