using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace FlipStringToMonotoneIncreasing
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"0", 0},
            new object[] {"1", 0},
            new object[] {"01", 0},
            new object[] {"10", 1},
            new object[] {"001000", 1},
            new object[] {"001000111", 1},
            new object[] {"00110", 1},
            new object[] {"010110", 2},
            new object[] {"00011000", 2},
            new object[] {"0101010101", 4},
            new object[] {"01010101010", 5},
            new object[] {"10101010101", 5},
            new object[] {"101010101010", 6},
            new object[] {"100111111100101110", 5},
            new object[] {"10011111110010111011", 5},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Memoization(string s, int expected)
        {
            var sol = new Solution();
            var res = sol.MinFlipsMonoIncr(s);

            Assert.AreEqual(expected, res);
        }
    }
}