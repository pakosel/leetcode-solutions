using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace PartitionArrayAccordingToGivenPivot
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[9,12,5,10,14,3,10]", 10, "[9,5,3,10,10,12,14]"},
            new object[] {"[-3,4,3,2]", 2, "[-3,2,4,3]"},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string numsStr, int pivot, string expectedStr)
        {
            var nums = ArrayHelper.ArrayFromString<int>(numsStr);
            var expected = ArrayHelper.ArrayFromString<int>(expectedStr);

            var sol = new Solution();
            var res = sol.PivotArray(nums, pivot);

            CollectionAssert.AreEqual(res, expected);
        }
    }
}