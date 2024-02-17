using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace IntervalListIntersections
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[]", "[]", "[]"},
            new object[] {"[[1,3],[5,9]]", "[]", "[]"},
            new object[] {"[]", "[[4,8],[10,12]]", "[]"},
            new object[] {"[[1,7]]", "[[3,10]]", "[[3,7]]"},
            new object[] {"[[0,2],[5,10],[13,23],[24,25]]", "[[1,5],[8,12],[15,24],[25,26]]", "[[1,2],[5,5],[8,10],[15,23],[24,24],[25,25]]"},
            new object[] {"[[0,2],[5,10],[13,23],[24,25]]", "[[2,5],[10,12],[24,27]]", "[[2,2],[5,5],[10,10],[24,25]]"},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string firstArrStr, string secondArrStr, string expectedArrStr)
        {
            var first = ArrayHelper.MatrixFromString<int>(firstArrStr);
            var second = ArrayHelper.MatrixFromString<int>(secondArrStr);

            var sol = new Solution();
            var res = sol.IntervalIntersection(first, second);
            var expected = ArrayHelper.MatrixFromString<int>(expectedArrStr);

            CollectionAssert.AreEqual(expected, res);
        }
    }
}