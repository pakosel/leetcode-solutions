using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace MergeSortedArray
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[]", 0, "[0]", 0, "[]"},
            new object[] {"[1]", 1, "[]", 0, "[1]"},
            new object[] {"[0]", 0, "[1]", 1, "[1]"},
            new object[] {"[1,2,3,0,0,0]", 3, "[2,5,6]", 3, "[1,2,2,3,5,6]"},
            
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_GenericStr(string arrStr1, int m, string arrStr2, int n, string expectedStr)
        {
            var nums1 = ArrayHelper.ArrayFromString(arrStr1);
            var nums2 = ArrayHelper.ArrayFromString(arrStr2);

            var sol = new Solution();
            sol.Merge(nums1, m, nums2, n);
            var expected = ArrayHelper.ArrayFromString(expectedStr);

            Assert.AreEqual(nums1, expected);
        }
    }
}