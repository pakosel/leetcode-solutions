using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace FindPlayersWithZeroOrOneLosses
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[[1,3],[2,3],[3,6],[5,6],[5,7],[4,5],[4,8],[4,9],[10,4],[10,9]]", "[[1,2,10],[4,5,7,8]]"},
            new object[] {"[[2,3],[1,3],[5,4],[6,4]]", "[[1,2,5,6],[]]"},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic24(string matchesStr, string expectedStr)
        {
            var matches = ArrayHelper.MatrixFromString<int>(matchesStr);
            var expected = ArrayHelper.MatrixFromString<int>(expectedStr);

            var sol = new Solution_2024();
            var res = sol.FindWinners(matches);

            CollectionAssert.AreEqual(expected, res);
        }

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string matchesStr, string expectedStr)
        {
            var matches = ArrayHelper.MatrixFromString<int>(matchesStr);
            var expected = ArrayHelper.MatrixFromString<int>(expectedStr);

            var sol = new Solution();
            var res = sol.FindWinners(matches);

            CollectionAssert.AreEqual(expected, res);
        }
    }
}