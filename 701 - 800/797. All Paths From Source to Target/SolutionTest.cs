using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace AllPathsFromSourceToTarget

{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[[1],[]]", "[[0,1]]"},
            new object[] {"[[1,2],[3],[3],[]]", "[[0,1,3],[0,2,3]]"},
            new object[] {"[[4,3,1],[3,2,4],[3],[4],[]]", "[[0,4],[0,3,4],[0,1,3,4],[0,1,2,3,4],[0,1,4]]"},
            new object[] {"[[1,2,3],[2],[3],[]]", "[[0,1,2,3],[0,2,3],[0,3]]"},
            new object[] {"[[1,3],[2],[3],[]]", "[[0,1,2,3],[0,3]]"},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_2022(string graphStr, string expectedArr)
        {
            var graph = ArrayHelper.MatrixFromString<int>(graphStr);

            var sol = new Solution_2022();
            var res = sol.AllPathsSourceTarget(graph);
            var expected = ArrayHelper.MatrixFromString<int>(expectedArr);

            CollectionAssert.AreEquivalent(res, expected);
        }

        [Test]
        [TestCaseSource("testCases")]
        public void Test_GenericStr(string graphStr, string expectedArr)
        {
            var graph = ArrayHelper.MatrixFromString<int>(graphStr);

            var sol = new Solution();
            var res = sol.AllPathsSourceTarget(graph);
            var expected = ArrayHelper.MatrixFromString<int>(expectedArr);

            CollectionAssert.AreEquivalent(res, expected);
        }
    }
}