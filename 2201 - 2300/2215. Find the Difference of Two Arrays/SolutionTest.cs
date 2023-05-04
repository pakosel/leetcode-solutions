using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace FindTheDifferenceOfTwoArrays
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[1,2,3]", "[2,4,6]", "[[1,3],[4,6]]"},
            new object[] {"[1,2,3,3]", "[1,1,2,2]", "[[3],[]]"},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string nums1Str, string nums2Str, string expectedStr)
        {
            var nums1 = ArrayHelper.ArrayFromString<int>(nums1Str);
            var nums2 = ArrayHelper.ArrayFromString<int>(nums2Str);
            var expected = ArrayHelper.MatrixFromString<int>(expectedStr);

            var sol = new Solution();
            var res = sol.FindDifference(nums1, nums2);

            CollectionAssert.AreEqual(expected, res);
        }
    }
}