using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace HouseRobber
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[1]", 1},
            new object[] {"[1,2,3,1]", 4},
            new object[] {"[2,7,9,3,1]", 12},
            new object[] {"[3,2,5,2,6,11]", 19},
            new object[] {"[3,2,5,2,6,11,10]", 24},
            new object[] {"[2,1,1,2]", 4},
            new object[] {"[1,2,2,1]", 3},
            new object[] {"[37,103,343,149,192,214,305,255,259,338,371,343,219,313,390,166,365,362,310,172,347,221,125,179,92,305,55,354,201,182,231,35,383,394,124,73,146,97,108,353,127,376,21,190,395,103,235,250,145,226,177,391,55,97,315,128,164,22,230,13,333,318,46,189,102,64,294,25,150,104,176,261,269,4,347,92,144,270,12,273,319,5,206,16,300,232,306,301,160,102,265,395,326,86,268,163,37,39,154,149]", 11929},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_2024(string numsStr, int expected)
        {
            var nums = ArrayHelper.ArrayFromString<int>(numsStr);

            var sol = new Solution_2024();
            var res = sol.Rob(nums);

            Assert.AreEqual(expected, res);
        }

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_2022(string numsStr, int expected)
        {
            var nums = ArrayHelper.ArrayFromString<int>(numsStr);

            var sol = new Solution_2022();
            var res = sol.Rob(nums);

            Assert.AreEqual(expected, res);
        }

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string numsStr, int expected)
        {
            var nums = ArrayHelper.ArrayFromString<int>(numsStr);

            var sol = new Solution();
            var res = sol.Rob(nums);

            Assert.AreEqual(expected, res);
        }
    }
}