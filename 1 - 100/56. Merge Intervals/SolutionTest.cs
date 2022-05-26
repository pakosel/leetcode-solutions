using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace MergeIntervals

{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[]", "[]"},
            new object[] {"[[1,3]]", "[[1,3]]"},
            new object[] {"[[1,3],[5,10]]", "[[1,3],[5,10]]"},
            new object[] {"[[1,3],[2,6],[8,10],[15,18]]", "[[1,6],[8,10],[15,18]]"},
            new object[] {"[[15,18],[1,3],[2,6],[2,3],[8,10],[1,3]]", "[[1,6],[8,10],[15,18]]"},
            new object[] {"[[1,3],[2,6],[8,10],[15,18],[2,50]]", "[[1,50]]"},
            new object[] {"[[1,4],[4,5]]", "[[1,5]]"},
            new object[] {"[[1,3],[2,5],[4,4],[5,11]]", "[[1,11]]"},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(string intervalsStr, string expected)
        {
            var intervals = ArrayHelper.MatrixFromString<int>(intervalsStr);
            var sol = new Solution();
            var res = sol.Merge(intervals);

            Assert.AreEqual(ArrayHelper.MatrixToString(res), expected);
        }       
    }
}