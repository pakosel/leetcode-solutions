using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace SumOfBeautyInTheArray
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[1,2,3]", 2},
            new object[] {"[2,4,6,4]", 1},
            new object[] {"[3,2,1]", 0},
            new object[] {"[1,2,3,4,5,6,7,8]", 12},
            new object[] {"[1,2,3,5,4,6,7,8]", 8},
            new object[] {"[1,2,3,5,4,6,7,8,7,6,5,4,3,2,1]", 4},
            new object[] {"[1,1,1,1]", 0},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string numsStr, int expected)
        {
            var nums = ArrayHelper.ArrayFromString<int>(numsStr);

            var sol = new Solution();
            var res = sol.SumOfBeauties(nums);

            Assert.AreEqual(expected, res);
        }
    }
}