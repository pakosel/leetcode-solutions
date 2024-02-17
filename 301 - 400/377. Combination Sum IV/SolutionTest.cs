using System;
using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace CombinationSumIV
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[1]", 1, 1},
            new object[] {"[1,2,3]", 4, 7},
            new object[] {"[9]", 3, 0},
            new object[] {"[1,2,3,4,5,6,7,8,10,12,13,14,15,16,17,18,19,20,22,25,27,30,33,40,45,46,47,48,50,55,56,57]", 30, 521498935},
            new object[] {"[3,1,2,4]", 4, 8},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test(string numsStr, int target, int expected)
        {
            var nums = ArrayHelper.ArrayFromString<int>(numsStr);

            var sol = new Solution();
            var res = sol.CombinationSum4(nums, target);

            ClassicAssert.AreEqual(expected, res);
        }
    }
}