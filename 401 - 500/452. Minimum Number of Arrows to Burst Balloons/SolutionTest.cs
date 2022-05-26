using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace MinimumNumberOfArrowsToBurstBalloons
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[[0,1]]", 1},
            new object[] {"[[10,16],[2,8],[1,6],[7,12]]", 2},
            new object[] {"[[1,2],[3,4],[5,6],[7,8]]", 4},
            new object[] {"[[1,2],[2,3],[3,4],[4,5]]", 2},
            new object[] {"[[3,9],[7,12],[3,8],[6,8],[9,10],[2,9],[0,9],[3,9],[0,6],[2,8]]", 2},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string arrStr, int expected)
        {
            var points = ArrayHelper.MatrixFromString<int>(arrStr);

            var sol = new Solution();
            var res = sol.FindMinArrowShots(points);

            Assert.AreEqual(res, expected);
        }
    }
}