using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;

namespace NumberOfDiceRollsWithTargetSum
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {1, 6, 3, 1},
            new object[] {2, 6, 7, 6},
            new object[] {30, 30, 500, 222616187},
            new object[] {10, 1, 10, 1},
            new object[] {30, 30, 200, 231359221},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(int n, int k, int target, int expected)
        {
            var sol = new Solution();
            var res = sol.NumRollsToTarget(n, k, target);

            Assert.That(expected == res);
        }
    }
}