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
            new object[] {2, "[]", -1},
            new object[] {2, "[[1,2]]", 2},
            new object[] {3, "[[1,3],[2,3]]", 3},
            new object[] {3, "[[1,3],[2,3],[3,1]]", -1},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic_2024(int n, string trustStr, int expected)
        {
            var trust = ArrayHelper.MatrixFromString<int>(trustStr);

            var sol = new Solution_2024();
            var res = sol.FindJudge(n, trust);

            Assert.That(expected == res);
        }
        

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic_2022(int n, string trustStr, int expected)
        {
            var trust = ArrayHelper.MatrixFromString<int>(trustStr);

            var sol = new Solution_2022();
            var res = sol.FindJudge(n, trust);

            Assert.That(expected == res);
        }
        
        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(int n, string trustStr, int expected)
        {
            var trust = ArrayHelper.MatrixFromString<int>(trustStr);

            var sol = new Solution();
            var res = sol.FindJudge(n, trust);

            Assert.That(expected == res);
        }
    }
}