using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace FindPairsWithSmallestSums
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[1,1,2]", "[1,2,3]", 10, "[[1,1],[1,1],[1,2],[2,1],[1,2],[2,2],[1,3],[1,3],[2,3]]"},
            new object[] {"[1,1,2,3,4,5,6]", "[1,1,1,1,1,1]", 18, "[[1,1],[1,1],[1,1],[1,1],[1,1],[1,1],[1,1],[1,1],[1,1],[1,1],[1,1],[1,1],[2,1],[2,1],[2,1],[2,1],[2,1],[2,1]]"},
            new object[] {"[1,7,11]", "[2,4,6]", 3, "[[1,2],[1,4],[1,6]]"},
            new object[] {"[1,1,2]", "[1,2,3]", 2, "[[1,1],[1,1]]"},
            new object[] {"[1,2]", "[3]", 3, "[[1,3],[2,3]]"},
            new object[] {"[1,2,3]", "[1,1,3]", 8, "[[1,1],[1,1],[2,1],[2,1],[3,1],[1,3],[3,1],[2,3]]"},
            new object[] {"[1,2,3]", "[1,1,3]", 18, "[[1,1],[1,1],[2,1],[2,1],[3,1],[1,3],[3,1],[2,3],[3,3]]"},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string nums1Str, string nums2Str, int k, string expectedStr)
        {
            var nums1 = ArrayHelper.ArrayFromString<int>(nums1Str);
            var nums2 = ArrayHelper.ArrayFromString<int>(nums2Str);
            var expected = ArrayHelper.MatrixFromString<int>(expectedStr);

            var sol = new Solution();
            var res = sol.KSmallestPairs(nums1, nums2, k);

            CollectionAssert.AreEquivalent(expected, res);
        }

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic23(string nums1Str, string nums2Str, int k, string expectedStr)
        {
            var nums1 = ArrayHelper.ArrayFromString<int>(nums1Str);
            var nums2 = ArrayHelper.ArrayFromString<int>(nums2Str);
            var expected = ArrayHelper.MatrixFromString<int>(expectedStr);

            var sol = new Solution_2023();
            var res = sol.KSmallestPairs(nums1, nums2, k);

            CollectionAssert.AreEqual(expected, res);
        }
    }
}