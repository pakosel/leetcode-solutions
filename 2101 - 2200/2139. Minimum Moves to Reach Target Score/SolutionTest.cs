using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace MinimumMovesToReachTargetScore
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {5, 0, 4},
            new object[] {19, 2, 7},
            new object[] {10, 4, 4},
            new object[] {10, 4, 4},
            new object[] {999999997, 0, 999999996},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(int target, int maxDoubles, int expected)
        {
            var sol = new Solution();
            var res = sol.MinMoves(target, maxDoubles);

            Assert.AreEqual(res, expected);
        }
    }
}