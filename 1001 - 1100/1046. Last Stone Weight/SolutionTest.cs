using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace LastStoneWeight
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[2,7,4,1,8,1]", 1},
            new object[] {"[1]", 1},
            new object[] {"[3,7]", 4},
            new object[] {"[2,7,4,1,8,1,16,15,1,3,22,7,5,6,111,55,12,4,6,5,5,5,8,8,7]", 0},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(string stonesStr, int expected)
        {
            var stones = ArrayHelper.ArrayFromString<int>(stonesStr);

            var sol = new Solution();
            var res = sol.LastStoneWeight(stones);

            Assert.AreEqual(expected, res);
        }
    }
}