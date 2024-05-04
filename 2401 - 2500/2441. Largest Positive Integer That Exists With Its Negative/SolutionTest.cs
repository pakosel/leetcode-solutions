using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace LargestPositiveIntegerThatExistsWithItsNegative
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[-1,2,-3,3]", 3},
            new object[] {"[-1,10,6,7,-7,1]", 7},
            new object[] {"[-10,8,6,7,-2,-3]", -1},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string numsStr, int expected)
        {
            var nums = ArrayHelper.ArrayFromString<int>(numsStr);
            
            var sol = new Solution();
            var res = sol.FindMaxK(nums);

            Assert.That(expected, Is.EqualTo(res));
        }
    }
}