using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace DeleteAndEarn
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[1]", 1},
            new object[] {"[3,4,2]", 6},
            new object[] {"[2,2,3,3,3,4]", 9},
            new object[] {"[3,1]", 4},
            new object[] {"[8,7,3,8,1,4,10,10,10,2]", 52},
            new object[] {"[3,7,10,5,2,4,8,9,9,4,9,2,6,4,6,5,4,7,6,10]", 66},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string numsStr, int expected)
        {
            var nums = ArrayHelper.ArrayFromString(numsStr);

            var sol = new Solution();
            var res = sol.DeleteAndEarn(nums);

            Assert.AreEqual(res, expected);
        }
    }
}