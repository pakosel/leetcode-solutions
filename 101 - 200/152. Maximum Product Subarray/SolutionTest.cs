using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace MaximumProductSubarray
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[0]", 0},
            new object[] {"[0,0]", 0},
            new object[] {"[0,1]", 1},
            new object[] {"[2,3,-2,4]", 6},
            new object[] {"[-2,0,-1]", 0},
            new object[] {"[2,-5,-2,-4,3]", 24},
            new object[] {"[5,6,10,-5,1,7,-10,-2,-3,-4,-6,0,9,4,-1,-9,-7,8,2,-8]", 15120000},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string numsStr, int expected)
        {
            var nums = ArrayHelper.ArrayFromString<int>(numsStr);

            var sol = new Solution();
            var res = sol.MaxProduct(nums);

            Assert.That(expected == res);
        }
    }
}