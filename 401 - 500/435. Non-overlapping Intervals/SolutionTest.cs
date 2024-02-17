using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace NonoverlappingIntervals
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[[0,1]]", 0},
            new object[] {"[[1,2],[2,3],[3,4],[1,3]]", 1},
            new object[] {"[[1,2],[1,2],[1,2]]", 2},
            new object[] {"[[1,2],[2,3]]", 0},
            new object[] {"[[3,9],[7,12],[3,8],[6,8],[9,10],[2,9],[0,9],[3,9],[0,6],[2,8]]", 7},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string arrStr, int expected)
        {
            var intervals = ArrayHelper.MatrixFromString<int>(arrStr);

            var sol = new Solution();
            var res = sol.EraseOverlapIntervals(intervals);

            Assert.That(expected == res);
        }
    }
}