using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace SumAbsoluteDifferencesInSortedArray
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] { "[2,3,5]", "[4,3,5]" },
            new object[] { "[1,4,6,8,10]", "[24,15,13,15,21]" },
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string strArr, string expected)
        {
            var nums = ArrayHelper.ArrayFromString<int>(strArr);

            var sol = new Solution();
            var res = sol.GetSumAbsoluteDifferences(nums);

            CollectionAssert.AreEquivalent(res, ArrayHelper.ArrayFromString<int>(expected));
        }
    }
}