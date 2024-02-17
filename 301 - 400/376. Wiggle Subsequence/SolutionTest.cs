using System;
using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace WiggleSubsequence
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[1,7,4,9,2,5]", 6},
            new object[] {"[1,17,5,10,13,15,10,5,16,8]", 7},
            new object[] {"[1,2,3,4,5,6,7,8,9]", 2},
            new object[] {"[1,7,4,9,2,5]", 6},
            new object[] {"[1,17,5,10,13,15,10,5,16,8]", 7},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test(string numsStr, int expected)
        {
            var nums = ArrayHelper.ArrayFromString<int>(numsStr);

            var sol = new Solution();
            var res = sol.WiggleMaxLength(nums);

            Assert.That(expected == res);
        }
    }
}