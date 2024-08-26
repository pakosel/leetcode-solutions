using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace IntersectionOfTwoArraysII
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[1,2,2,1]", "[2,2]", "[2,2]"},
            new object[] {"[4,9,5]", "[9,4,9,8,4]", "[9,4]"},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Stack(string nums1Str, string nums2Str, string expectedStr)
        {
            var nums1 = ArrayHelper.ArrayFromString<int>(nums1Str);
            var nums2 = ArrayHelper.ArrayFromString<int>(nums2Str);
            var expected = ArrayHelper.ArrayFromString<int>(expectedStr);

            var sol = new Solution();
            var res = sol.Intersect(nums1, nums2);

            Assert.That(res, Is.EqualTo(expected));
        }
    }
}