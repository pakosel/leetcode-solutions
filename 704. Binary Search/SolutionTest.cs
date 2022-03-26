using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace BinarySearch
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[-1,0,3,5,9,12]", 9, 4},
            new object[] {"[-1,0,3,5,9,12]", 2, -1},
            new object[] {"[-1,0,3,5,9,12]", 15, -1},
            new object[] {"[-1,0,3,5,9,12]", -5, -1},
            new object[] {"[1]", 1, 0},
            new object[] {"[1]", 2, -1},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string numsStr, int target, int expected)
        {
            var nums = ArrayHelper.ArrayFromString(numsStr);

            var sol = new Solution();
            var res = sol.Search(nums, target);

            Assert.AreEqual(res, expected);
        }
    }
}