using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace MinimumScoreOfPathBetweenTwoCities
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {4, "[[1,2,9],[2,3,6],[2,4,5],[1,4,7]]", 5},
            new object[] {4, "[[1,2,2],[1,3,4],[3,4,7]]", 2},
            new object[] {4, "[[2,3,6],[1,4,7]]", 7},
            new object[] {4, "[[2,3,6],[2,4,5],[1,4,7]]", 5},
            new object[] {4, "[[2,3,2],[2,4,5],[1,4,7]]", 2},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(int n, string roadsStr, int expected)
        {
            var roads = ArrayHelper.MatrixFromString<int>(roadsStr);
            
            var sol = new Solution();
            var res = sol.MinScore(n, roads);

            Assert.AreEqual(expected, res);
        }
    }
}