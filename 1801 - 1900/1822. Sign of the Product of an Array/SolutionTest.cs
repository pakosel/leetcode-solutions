using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace SignOfTheProductOfAnArray
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[-1,-2,-3,-4,3,2,1]", 1},
            new object[] {"[1,5,0,2,-3]", 0},
            new object[] {"[-1,1,-1,1,-1]", -1},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string numsStr, int expected)
        {
            var nums = ArrayHelper.ArrayFromString<int>(numsStr);

            var sol = new Solution();
            var res = sol.ArraySign(nums);

            Assert.AreEqual(expected, res);
        }
    }
}