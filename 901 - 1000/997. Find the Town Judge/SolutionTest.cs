using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace FindTheTownJudge
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {1, "[]", 1},
            new object[] {2, "[[1,2]]", 2},
            new object[] {3, "[[1,3],[2,3]]", 3},
            new object[] {3, "[[1,3],[2,3],[3,1]]", -1},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(int n, string trustStr, int expected)
        {
            var trust = ArrayHelper.MatrixFromString(trustStr);

            var sol = new Solution();
            var res = sol.FindJudge(n, trust);

            Assert.AreEqual(res, expected);
        }
    }
}