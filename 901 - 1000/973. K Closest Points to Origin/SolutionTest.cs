using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace KClosestPointsToOrigin
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[[1,3],[-2,2]]", 1, "[[-2,2]]"},
            new object[] {"[[3,3],[5,-1],[-2,4]]", 2, "[[3,3],[-2,4]]"},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string pointsStr, int k, string expectedStr)
        {
            var points = ArrayHelper.MatrixFromString<int>(pointsStr);
            var expected = ArrayHelper.MatrixFromString<int>(expectedStr);

            var sol = new Solution();
            var res = sol.KClosest(points, k);

            Assert.That(res, Is.EquivalentTo(expected));
        }
    }
}