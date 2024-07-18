using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace WaterBottles
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {9, 3, 13},
            new object[] {15, 4, 19},
            new object[] {1, 2, 1},
            new object[] {2, 2, 3},
            new object[] {16, 4, 21},
            new object[] {37, 7, 43},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(int numBottles, int numExchange, int expected)
        {
            var sol = new Solution();
            var res = sol.NumWaterBottles(numBottles, numExchange);

            Assert.That(expected, Is.EqualTo(res));
        }
    }
}