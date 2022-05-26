using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace MaxNumberOfKSumPairs
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[1,2,3,4]", 5, 2},
            new object[] {"[3,1,3,4,3]", 6, 1},
            new object[] {"[5]", 5, 0},
            new object[] {"[1,1,1,1,1,1,1]", 2, 3},
            new object[] {"[1,1,1,1,1,1,1,1]", 2, 4},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string numsStr, int k, int expected)
        {
            var nums = ArrayHelper.ArrayFromString<int>(numsStr);

            var sol = new Solution();
            var res = sol.MaxOperations(nums, k);

            Assert.AreEqual(res, expected);
        }
    }
}