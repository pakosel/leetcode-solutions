using System;
using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace SlidingWindowMaximum
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[1]", 1, "[1]"},
            new object[] {"[1,3,-1,-3,5,3,6,7]", 3, "[3,3,5,5,6,7]"},
            new object[] {"[1,2,3,4,5,6,7]", 3, "[3,4,5,6,7]"},
            new object[] {"[1,2,3,4,5,6,7]", 2, "[2,3,4,5,6,7]"},
            new object[] {"[7,6,5,4,3,2,1]", 2, "[7,6,5,4,3,2]"},
            new object[] {"[7,6,5,4,3,2,1]", 4, "[7,6,5,4]"},
            new object[] {"[1,7,2,6,4,1,2,1,3]", 3, "[7,7,6,6,4,2,3]"},
            new object[] {"[1,1,1,1,1,1]", 2, "[1,1,1,1,1]"},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string numsStr, int k, string expectedStr)
        {
            var nums = ArrayHelper.ArrayFromString<int>(numsStr);
            var expected = ArrayHelper.ArrayFromString<int>(expectedStr);

            var sol = new Solution();
            var res = sol.MaxSlidingWindow(nums, k);

            CollectionAssert.AreEqual(expected, res);
        }
    }
}