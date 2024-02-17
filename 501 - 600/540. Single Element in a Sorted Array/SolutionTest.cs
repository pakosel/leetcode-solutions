using System;
using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace SingleElementInSortedArray
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[1]", 1},
            new object[] {"[1,1,5]", 5},
            new object[] {"[1,5,5]", 1},
            new object[] {"[1,1,3,5,5]", 3},
            new object[] {"[1,2,2,5,5]", 1},
            new object[] {"[1,1,2,2,5]", 5},
            new object[] {"[1,1,2,3,3,5,5,8,8]", 2},
            new object[] {"[1,1,3,3,4,4,5,8,8]", 5},
            new object[] {"[1,1,3,3,4,5,5,8,8]", 4},
            new object[] {"[3,3,7,7,10,11,11]", 10},
            new object[] {"[3,3,7,10,10,11,11]", 7},
            new object[] {"[1,1,2,2,4,5,5]", 4},
            new object[] {"[1,1,3,3,4,4,5,5,6,8,8]", 6},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string strArr, int expected)
        {
            var nums = ArrayHelper.ArrayFromString<int>(strArr);

            var sol = new Solution();
            var res = sol.SingleNonDuplicate(nums);

            Assert.That(expected == res);
        }
    }
}