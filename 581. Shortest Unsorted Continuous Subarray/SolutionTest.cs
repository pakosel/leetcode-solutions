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
            new object[] { "[1,2,3,5,4]", 2 },
            new object[] { "[-94,0,49,-100,26,29,74,86,-15,16,7,23,38,32,88,-63,-86,-38,-34,97,-31,-23,82,-58,20,78,-85,-75,-35,75,-14,-89,-72,42,-18,47,-66,1,-3,-6,-4,22,-68,6,98,-60,-62,85,50,-95,36,-1,-16,2,94,62,46,81,19,34,25,70,-44,-5,5,-50,-53,37,41,51,-8,80,93,65,-33,-81,-79,-91,3,87,-26,31,-36,-11,96,-69,67,-45,-47,27,-27,-77,71,58,92,-82,63,-39,-2,89]", 100},
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