using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace SortTheMatrixDiagonally
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[[3,3,1,1],[2,2,1,2],[1,1,1,2]]", "[[1,1,1,1],[1,2,2,2],[1,2,3,3]]"},
            new object[] {"[[1,3,1,1],[2,1,1,2],[1,1,1,2]]", "[[1,1,1,1],[1,1,2,2],[1,2,1,3]]"},
            new object[] {"[[11,25,66,1,69,7],[23,55,17,45,15,52],[75,31,36,44,58,8],[22,27,33,25,68,4],[84,28,14,11,5,50]]", "[[5,17,4,1,52,7],[11,11,25,45,8,69],[14,23,25,44,58,15],[22,27,31,36,50,66],[84,28,75,33,55,68]]"},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(string matStr, string expectedStr)
        {
            var mat = ArrayHelper.MatrixFromString<int>(matStr);
            var expected = ArrayHelper.MatrixFromString<int>(expectedStr);

            var sol = new Solution();
            var res = sol.DiagonalSort(mat);

            Assert.That(res, Is.EqualTo(expected));
        }
    }
}