using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace FindTheWinnerOfTheCircularGame
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {1, 1, 1},
            new object[] {5, 2, 3},
            new object[] {6, 5, 1},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(int n, int k, int expected)
        {
            var sol = new Solution();
            var res = sol.FindTheWinner(n, k);

            Assert.That(expected, Is.EqualTo(res));
        }
    }
}