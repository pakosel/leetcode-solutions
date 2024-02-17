using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace PartitionArraySuchThatMaximumDifferenceIsK
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[3,6,1,2,5]", 2, 2},
            new object[] {"[1,2,3]", 1, 2},
            new object[] {"[2,2,4,5]", 0, 3},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string numsStr, int k, int expected)
        {
            var nums = ArrayHelper.ArrayFromString<int>(numsStr);

            var sol = new Solution();
            var res = sol.PartitionArray(nums, k);

            Assert.That(expected == res);
        }
    }
}