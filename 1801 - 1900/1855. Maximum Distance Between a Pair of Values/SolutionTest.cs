using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace MaximumDistanceBetweenPairOfValues
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[55,30,5,4,2]", "[100,20,10,10,5]", 2},
            new object[] {"[2,2,2]", "[10,10,1]", 1},
            new object[] {"[30,29,19,5]", "[25,25,25,25,25]", 2},
            new object[] {"[5,4]", "[3,2]", 0},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string nums1Str, string nums2Str, int expected)
        {
            var nums1 = ArrayHelper.ArrayFromString<int>(nums1Str);
            var nums2 = ArrayHelper.ArrayFromString<int>(nums2Str);

            var sol = new Solution();
            var res = sol.MaxDistance(nums1, nums2);

            Assert.AreEqual(res, expected);
        }
    }
}