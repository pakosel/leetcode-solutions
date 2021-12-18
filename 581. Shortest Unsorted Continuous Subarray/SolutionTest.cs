using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace ShortestUnsortedContinuousSubarray
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] { "[1]", 0 },
            new object[] { "[1,1,1]", 0 },
            new object[] { "[1,2]", 0 },
            new object[] { "[2,1]", 2 },
            new object[] { "[1,2,1]", 2 },
            new object[] { "[1,2,1,3]", 2 },
            new object[] { "[1,2,1,3,0]", 5 },
            new object[] { "[2,6,4,8,10,9,15]", 5 },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string arrStr, int expected)
        {
            var nums = ArrayHelper.ArrayFromString(arrStr);

            var sol = new Solution();
            var res = sol.FindUnsortedSubarray(nums);

            Assert.AreEqual(res, expected);
        }
    }
}