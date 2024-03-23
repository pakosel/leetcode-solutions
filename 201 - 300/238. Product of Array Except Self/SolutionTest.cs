using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace ProductOfArrayExceptSelf
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[1,2,3,4]", "[24,12,8,6]"},
            new object[] {"[-1,1,0,-3,3]", "[0,0,9,0,0]"},
            new object[] {"[0,2,3,4]", "[24,0,0,0]"},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string numsStr, string expectedStr)
        {
            var nums = ArrayHelper.ArrayFromString<int>(numsStr);
            var expected = ArrayHelper.ArrayFromString<int>(expectedStr);

            var sol = new Solution();
            var res = sol.ProductExceptSelf(nums);

            Assert.That(res, Is.EqualTo(expected));
        }
    }
}