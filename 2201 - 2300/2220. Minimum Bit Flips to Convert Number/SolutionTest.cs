using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace MinimumBitFlipsToConvertNumber
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {0, 0, 0},
            new object[] {1, 1, 0},
            new object[] {10, 7, 3},
            new object[] {3, 4, 3},
            new object[] {10, 1, 3},
            new object[] {10000, 16, 4},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(int start, int goal, int expected)
        {
            var sol = new Solution();
            var res = sol.MinBitFlips(start, goal);

            ClassicAssert.AreEqual(expected, res);
        }
    }
}