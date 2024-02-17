using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace MaximumLengthOfRepeatedSubarray
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[1,2,3,2,1]","[3,2,1,4,7]", 3},
            new object[] {"[0,0,0,0,0]","[0,0,0,0,0]", 5},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Example(string nums1Str, string nums2Str, int expected)
        {
            var nums1 = ArrayHelper.ArrayFromString<int>(nums1Str);
            var nums2 = ArrayHelper.ArrayFromString<int>(nums2Str);

            var sol = new Solution();
            var res = sol.FindLength(nums1, nums2);

            Assert.That(expected == res);
        }
    }
}